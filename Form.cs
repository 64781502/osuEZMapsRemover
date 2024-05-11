using System.Diagnostics;

namespace osuezmapsremover
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly Main main;

        public string DIR_PATH { get; set; }
        public string APP_NAME { get; set; }

        public TextBox DiffBoxComponent { get; set; }
        public ProgressBar ProgressBar { get; set; }
        public CheckBox CaseSensitiveButton { get; set; }
        public RichTextBox FileTextBox { get; set; } // change to interactable listbox later maybe
        public ListBox SearchByBox { get; set; }
        public Label LabelShowComponent { get; set; }

        public Form()
        {
            InitializeComponent();

            DIR_PATH = "dir.txt";
            APP_NAME = "osuEZMapsRemover";

            DiffBoxComponent = DiffBox;
            ProgressBar = ProgressBar1;
            CaseSensitiveButton = CaseSensitive;
            FileTextBox = FileList;
            SearchByBox = SearchByTypeBox;
            LabelShowComponent = LabelShow;

            this.main = new Main(this);
        }

        private void DeleteButonClick(object sender, EventArgs e)
        {
            main.RunTool(); // delete
        }

        private void SensitiveBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SensitiveBox.Checked && LabelShow.Text == "Progress:") // allow the user to press the button
            {
                DeleteButton.Enabled = true;
            }
            else
            {
                DeleteButton.Enabled = false;
            }
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            main.DisplayMaps();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.Text += " | Logged in as " + Main.GetOsuUsername();

            if (!Directory.Exists(FilePath.GetRawOsuDir()) && !File.Exists(DIR_PATH))
            {
                MessageBox.Show("osu path not found", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            SearchByTypeBox.SelectedIndex = (int)SearchByBoxIndex.Diff; // show difficulty on start
        }

        #region form hold cursor thing whatever
        private Point lastPoint;
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e) { lastPoint = new Point(e.X, e.Y); }
        #endregion

        private void SearchByTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedItem = SearchByTypeBox.Items[SearchByTypeBox.SelectedIndex].ToString();

            SearchLabel.Text = $"{selectedItem} search:";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            main.Beatmaps.Clear();

            main.GetAllMaps();
            main.DisplayMaps();
        }

        private void JsonButton_Click(object sender, EventArgs e)
        {
            main.CreateJSONFile();
        }

        private void LoadAllMapsButton_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string loading_text = " | Loading...";
            this.Text += loading_text;

            main.GetAllMaps();

            stopwatch.Stop();

            this.Text = this.Text.Remove(this.Text.Length - loading_text.Length);

            MessageBox.Show($"Loaded all maps in {stopwatch.Elapsed.TotalSeconds} seconds.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}