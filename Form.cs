using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace osuezmapsdelete
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        static private string osuDir()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\osu!\\Songs";
        }

        static private string rawOsuDir()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\osu!";
        }

        private void DeleteButonClick(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(osuDir(), "*.osu", SearchOption.AllDirectories);
            List<string> ToDelete = new List<string>();
            List<string> ToDeleteDir = new List<string>();
            int count = 0;

            if (DiffBox.Text != "")
            {
                foreach (string y in files)
                {
                    var lines = File.ReadLines(y);
                    foreach (var line in lines)
                    {
                        if (line.StartsWith("Version:"))
                        {
                            string difficulty = line.Substring(line.IndexOf(":") + 1);
                            if (difficulty.Contains(DiffBox.Text))
                            {
                                if (Directory.GetFiles(Directory.GetParent(y).ToString(), "*.osu", SearchOption.TopDirectoryOnly).Length == 1) //prevent osu glitch
                                {
                                    ToDeleteDir.Add(Directory.GetParent(y).ToString());
                                }
                                else
                                {
                                    ToDelete.Add(y);
                                }
                            }
                        }
                    }
                }
            }

            foreach (string y in ToDelete)
            {
                File.Delete(y);
                count += 1;
                ProgressBar1.Value = count;
            }

            foreach (string y in ToDeleteDir)
            {
                Directory.Delete(y, true);
                count += 1;
                ProgressBar1.Value = count;
            }
        }

        private void SensitiveBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SensitiveBox.Checked) { DeleteButton.Enabled = true; }
            else { DeleteButton.Enabled = false; }
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            LabelShow.Text = "Progress:";
            FileList.Text = null;
            int count = 0;
            string[] files = Directory.GetFiles(osuDir(), "*.osu", SearchOption.AllDirectories); //filter only diff files
            

            if (DiffBox.Text != "")
            {
                foreach (string y in files)
                {
                    var lines = File.ReadLines(y);
                    foreach (var line in lines)
                    {
                        if (line.StartsWith("Version:")) //find line with diff name
                        {
                            string difficulty = line.Substring(line.IndexOf(":") + 1); //get diff name

                            if (difficulty.Contains(DiffBox.Text))
                            {
                                count += 1;
                                string x = y.Substring(Convert.ToInt32(y.IndexOf(osuDir()) + osuDir().Length + 1), Convert.ToInt32(y.LastIndexOf(".osu")) - Convert.ToInt32(y.IndexOf(osuDir()) + osuDir().Length + 1));
                                FileList.Text += x + "\n";
                            }
                        }
                    }
                }
            }
            ProgressBar1.Maximum = count;
            FileList.Text = "FOUND " + count.ToString() + " MAPS\n\n" + FileList.Text;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            if (File.Exists(rawOsuDir() + "\\osu!." + Environment.UserName + ".cfg"))
            {
                var lines = File.ReadLines(rawOsuDir() + "\\osu!." + Environment.UserName + ".cfg");
                foreach (var line in lines)
                {
                    if (line.StartsWith("Username = "))
                    {
                        Logged.Text = "Logged in as " + line.Substring(line.IndexOf("=") + 2);
                    }
                }
            }
            else
            {
                Logged.Text = null;
            }
        }
    }
}
