
namespace osuezmapsremover
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            FileList = new RichTextBox();
            DeleteButton = new Button();
            DiffBox = new TextBox();
            SensitiveBox = new CheckBox();
            SearchLabel = new Label();
            SearchB = new Button();
            ProgressBar1 = new ProgressBar();
            LabelShow = new Label();
            CaseSensitive = new CheckBox();
            SearchByTypeBox = new ListBox();
            RefreshButton = new Button();
            JsonButton = new Button();
            LoadAllMapsButton = new Button();
            SuspendLayout();
            // 
            // FileList
            // 
            FileList.BackColor = Color.FromArgb(245, 242, 243);
            FileList.DetectUrls = false;
            FileList.Font = new Font("Inter", 13F);
            FileList.ForeColor = Color.Black;
            FileList.ImeMode = ImeMode.NoControl;
            FileList.Location = new Point(347, 14);
            FileList.Margin = new Padding(4, 3, 4, 3);
            FileList.Name = "FileList";
            FileList.ReadOnly = true;
            FileList.Size = new Size(790, 476);
            FileList.TabIndex = 3;
            FileList.Text = "";
            FileList.WordWrap = false;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(245, 242, 243);
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.Enabled = false;
            DeleteButton.Font = new Font("Inter", 9.75F);
            DeleteButton.ForeColor = Color.Black;
            DeleteButton.Location = new Point(117, 294);
            DeleteButton.Margin = new Padding(4, 3, 4, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(110, 27);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Mass delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButonClick;
            // 
            // DiffBox
            // 
            DiffBox.BackColor = Color.FromArgb(245, 242, 243);
            DiffBox.Font = new Font("Inter", 9.75F);
            DiffBox.ForeColor = Color.Black;
            DiffBox.Location = new Point(14, 197);
            DiffBox.Margin = new Padding(4, 3, 4, 3);
            DiffBox.Name = "DiffBox";
            DiffBox.Size = new Size(258, 23);
            DiffBox.TabIndex = 0;
            // 
            // SensitiveBox
            // 
            SensitiveBox.AutoSize = true;
            SensitiveBox.BackColor = Color.FromArgb(245, 242, 243);
            SensitiveBox.Font = new Font("Inter", 9.75F);
            SensitiveBox.ForeColor = Color.Black;
            SensitiveBox.Location = new Point(60, 267);
            SensitiveBox.Margin = new Padding(4, 3, 4, 3);
            SensitiveBox.Name = "SensitiveBox";
            SensitiveBox.Size = new Size(234, 20);
            SensitiveBox.TabIndex = 1;
            SensitiveBox.Text = "I want to delete those beatmaps.";
            SensitiveBox.UseVisualStyleBackColor = false;
            SensitiveBox.CheckedChanged += SensitiveBox_CheckedChanged;
            // 
            // SearchLabel
            // 
            SearchLabel.BackColor = Color.FromArgb(245, 242, 243);
            SearchLabel.Font = new Font("Inter", 12F);
            SearchLabel.ForeColor = Color.Black;
            SearchLabel.Location = new Point(14, 169);
            SearchLabel.Margin = new Padding(4, 0, 4, 0);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(174, 24);
            SearchLabel.TabIndex = 4;
            SearchLabel.Text = "Difficulty search:";
            // 
            // SearchB
            // 
            SearchB.BackColor = Color.FromArgb(245, 242, 243);
            SearchB.Font = new Font("Inter", 9.75F);
            SearchB.ForeColor = Color.Black;
            SearchB.Location = new Point(280, 195);
            SearchB.Margin = new Padding(4, 3, 4, 3);
            SearchB.Name = "SearchB";
            SearchB.Size = new Size(59, 24);
            SearchB.TabIndex = 6;
            SearchB.Text = "Show";
            SearchB.UseVisualStyleBackColor = false;
            SearchB.Click += SearchB_Click;
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(14, 394);
            ProgressBar1.Margin = new Padding(4, 3, 4, 3);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(313, 27);
            ProgressBar1.Style = ProgressBarStyle.Continuous;
            ProgressBar1.TabIndex = 9;
            // 
            // LabelShow
            // 
            LabelShow.BackColor = Color.FromArgb(245, 242, 243);
            LabelShow.Font = new Font("Inter", 9.75F);
            LabelShow.ForeColor = Color.Black;
            LabelShow.Location = new Point(14, 374);
            LabelShow.Margin = new Padding(4, 0, 4, 0);
            LabelShow.Name = "LabelShow";
            LabelShow.Size = new Size(313, 17);
            LabelShow.TabIndex = 10;
            LabelShow.Text = "Click \"Show\" to see the progress and maps.";
            LabelShow.TextAlign = ContentAlignment.TopCenter;
            // 
            // CaseSensitive
            // 
            CaseSensitive.AutoSize = true;
            CaseSensitive.BackColor = Color.FromArgb(245, 242, 243);
            CaseSensitive.Checked = true;
            CaseSensitive.CheckState = CheckState.Checked;
            CaseSensitive.Font = new Font("Inter", 9.75F);
            CaseSensitive.ForeColor = Color.Black;
            CaseSensitive.Location = new Point(14, 135);
            CaseSensitive.Margin = new Padding(4, 3, 4, 3);
            CaseSensitive.Name = "CaseSensitive";
            CaseSensitive.Size = new Size(117, 20);
            CaseSensitive.TabIndex = 14;
            CaseSensitive.Text = "Case sensitive";
            CaseSensitive.UseVisualStyleBackColor = false;
            // 
            // SearchByTypeBox
            // 
            SearchByTypeBox.BackColor = Color.FromArgb(245, 242, 243);
            SearchByTypeBox.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SearchByTypeBox.ForeColor = Color.Black;
            SearchByTypeBox.FormattingEnabled = true;
            SearchByTypeBox.Items.AddRange(new object[] { "Title", "Artist", "Mapper", "Difficulty", "Beatmap ID", "BeatmapSet ID" });
            SearchByTypeBox.Location = new Point(12, 12);
            SearchByTypeBox.Name = "SearchByTypeBox";
            SearchByTypeBox.Size = new Size(247, 100);
            SearchByTypeBox.TabIndex = 16;
            SearchByTypeBox.SelectedIndexChanged += SearchByTypeBox_SelectedIndexChanged;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.FromArgb(245, 242, 243);
            RefreshButton.Font = new Font("Inter", 9.75F);
            RefreshButton.ForeColor = Color.Black;
            RefreshButton.Location = new Point(14, 430);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(89, 27);
            RefreshButton.TabIndex = 17;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // JsonButton
            // 
            JsonButton.BackColor = Color.FromArgb(245, 242, 243);
            JsonButton.Font = new Font("Inter", 9.75F);
            JsonButton.ForeColor = Color.Black;
            JsonButton.Location = new Point(14, 463);
            JsonButton.Name = "JsonButton";
            JsonButton.Size = new Size(174, 27);
            JsonButton.TabIndex = 18;
            JsonButton.Text = "Save all maps as JSON";
            JsonButton.UseVisualStyleBackColor = false;
            JsonButton.Click += JsonButton_Click;
            // 
            // LoadAllMapsButton
            // 
            LoadAllMapsButton.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LoadAllMapsButton.Location = new Point(265, 12);
            LoadAllMapsButton.Name = "LoadAllMapsButton";
            LoadAllMapsButton.Size = new Size(75, 100);
            LoadAllMapsButton.TabIndex = 19;
            LoadAllMapsButton.Text = "LOAD ALL MAPS";
            LoadAllMapsButton.UseVisualStyleBackColor = false;
            LoadAllMapsButton.Click += LoadAllMapsButton_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(245, 242, 243);
            ClientSize = new Size(1146, 502);
            Controls.Add(LoadAllMapsButton);
            Controls.Add(JsonButton);
            Controls.Add(RefreshButton);
            Controls.Add(SearchByTypeBox);
            Controls.Add(CaseSensitive);
            Controls.Add(LabelShow);
            Controls.Add(ProgressBar1);
            Controls.Add(SearchB);
            Controls.Add(SearchLabel);
            Controls.Add(SensitiveBox);
            Controls.Add(DiffBox);
            Controls.Add(DeleteButton);
            Controls.Add(FileList);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form";
            Text = "osuEZMapsRemover";
            Load += Form_Load;
            MouseDown += Form_MouseDown;
            MouseMove += Form_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox FileList;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox DiffBox;
        private System.Windows.Forms.CheckBox SensitiveBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Label LabelShow;
        private System.Windows.Forms.CheckBox CaseSensitive;
        private ListBox SearchByTypeBox;
        private Button RefreshButton;
        private Button JsonButton;
        private Button LoadAllMapsButton;
    }
}