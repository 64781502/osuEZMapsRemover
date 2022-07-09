using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace osuezmapsdelete
{
    public partial class Form : System.Windows.Forms.Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        static private string osuDir()
        {
            if (File.Exists("dir.txt"))
            {
                return File.ReadAllText("dir.txt").Replace(@"\", "\\") + "\\Songs";
            }
            else
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\osu!\\Songs";
            }
        }

        static private string rawOsuDir()
        {
            if (File.Exists("dir.txt"))
            {
                return File.ReadAllText("dir.txt").Replace(@"\", "\\");
            }
            else
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\osu!";
            }
        }

        private void RunTool()
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

            MessageBox.Show(DiffBox.Text + " maps have been deleted!", "osuEZMapsRemover", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void DeleteButonClick(object sender, EventArgs e)
        {
            RunTool();
        }

        private void SensitiveBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SensitiveBox.Checked && LabelShow.Text == "Progress:") {
                DeleteButton.Enabled = true;
            }
            else {
                DeleteButton.Enabled = false;
            }
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            LabelShow.Text = "Progress:";
            FileList.Text = null;
            int count = 0;
            string[] files = Directory.GetFiles(osuDir(), "*.osu", SearchOption.AllDirectories); //filter only diff files
            int allmaps = files.Length;
            

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
            FileList.Text = "Found " + count + " beatmaps\n" + "Total beatmaps in osu directory: ≈" + allmaps + " (not deleting)\n\n" + FileList.Text;
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

            if (Directory.Exists(rawOsuDir()) == false && File.Exists("dir.txt") == false)
            {
                MessageBox.Show("osu path not found", "osuEZMapsRemover", MessageBoxButtons.OK, MessageBoxIcon.Error); Application.Exit();
            }
        }

        //Binfy
        Point lastPoint;
        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseIcon_MouseDown(object sender, MouseEventArgs e) { Application.Exit(); }
    }
}
