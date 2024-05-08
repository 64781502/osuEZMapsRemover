
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.FileList = new System.Windows.Forms.RichTextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DiffBox = new System.Windows.Forms.TextBox();
            this.SensitiveBox = new System.Windows.Forms.CheckBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchB = new System.Windows.Forms.Button();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.LabelShow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreatorRatioButton = new System.Windows.Forms.RadioButton();
            this.TitleRatioButton = new System.Windows.Forms.RadioButton();
            this.DiffRatioButton = new System.Windows.Forms.RadioButton();
            this.CaseSensitive = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileList
            // 
            this.FileList.BackColor = System.Drawing.Color.Gray;
            this.FileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FileList.DetectUrls = false;
            this.FileList.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileList.ForeColor = System.Drawing.Color.White;
            this.FileList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FileList.Location = new System.Drawing.Point(297, 12);
            this.FileList.Name = "FileList";
            this.FileList.ReadOnly = true;
            this.FileList.Size = new System.Drawing.Size(881, 419);
            this.FileList.TabIndex = 3;
            this.FileList.Text = "";
            this.FileList.WordWrap = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.Location = new System.Drawing.Point(92, 208);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Mass delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButonClick);
            // 
            // DiffBox
            // 
            this.DiffBox.BackColor = System.Drawing.Color.White;
            this.DiffBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiffBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiffBox.Location = new System.Drawing.Point(62, 111);
            this.DiffBox.Name = "DiffBox";
            this.DiffBox.Size = new System.Drawing.Size(149, 22);
            this.DiffBox.TabIndex = 0;
            // 
            // SensitiveBox
            // 
            this.SensitiveBox.AutoSize = true;
            this.SensitiveBox.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SensitiveBox.ForeColor = System.Drawing.Color.White;
            this.SensitiveBox.Location = new System.Drawing.Point(43, 185);
            this.SensitiveBox.Name = "SensitiveBox";
            this.SensitiveBox.Size = new System.Drawing.Size(207, 19);
            this.SensitiveBox.TabIndex = 1;
            this.SensitiveBox.Text = "I want to delete those beatmaps.";
            this.SensitiveBox.UseVisualStyleBackColor = true;
            this.SensitiveBox.CheckedChanged += new System.EventHandler(this.SensitiveBox_CheckedChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchLabel.ForeColor = System.Drawing.Color.White;
            this.SearchLabel.Location = new System.Drawing.Point(62, 87);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(149, 21);
            this.SearchLabel.TabIndex = 4;
            this.SearchLabel.Text = "Difficulty search:";
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.White;
            this.SearchB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchB.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchB.Location = new System.Drawing.Point(213, 111);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(51, 22);
            this.SearchB.TabIndex = 6;
            this.SearchB.Text = "Show";
            this.SearchB.UseVisualStyleBackColor = false;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(12, 359);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(268, 23);
            this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar1.TabIndex = 9;
            // 
            // LabelShow
            // 
            this.LabelShow.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelShow.ForeColor = System.Drawing.Color.White;
            this.LabelShow.Location = new System.Drawing.Point(12, 343);
            this.LabelShow.Name = "LabelShow";
            this.LabelShow.Size = new System.Drawing.Size(268, 13);
            this.LabelShow.TabIndex = 10;
            this.LabelShow.Text = "Click \"Show\" to see the progress and maps.";
            this.LabelShow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreatorRatioButton);
            this.panel1.Controls.Add(this.TitleRatioButton);
            this.panel1.Controls.Add(this.DiffRatioButton);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 29);
            this.panel1.TabIndex = 13;
            // 
            // CreatorRatioButton
            // 
            this.CreatorRatioButton.AutoSize = true;
            this.CreatorRatioButton.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreatorRatioButton.ForeColor = System.Drawing.Color.White;
            this.CreatorRatioButton.Location = new System.Drawing.Point(200, 3);
            this.CreatorRatioButton.Name = "CreatorRatioButton";
            this.CreatorRatioButton.Size = new System.Drawing.Size(81, 23);
            this.CreatorRatioButton.TabIndex = 2;
            this.CreatorRatioButton.Text = "Creator";
            this.CreatorRatioButton.UseVisualStyleBackColor = true;
            this.CreatorRatioButton.CheckedChanged += new System.EventHandler(this.CreatorRatioButton_CheckedChanged);
            // 
            // TitleRatioButton
            // 
            this.TitleRatioButton.AutoSize = true;
            this.TitleRatioButton.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleRatioButton.ForeColor = System.Drawing.Color.White;
            this.TitleRatioButton.Location = new System.Drawing.Point(120, 4);
            this.TitleRatioButton.Name = "TitleRatioButton";
            this.TitleRatioButton.Size = new System.Drawing.Size(59, 23);
            this.TitleRatioButton.TabIndex = 1;
            this.TitleRatioButton.Text = "Title";
            this.TitleRatioButton.UseVisualStyleBackColor = true;
            this.TitleRatioButton.CheckedChanged += new System.EventHandler(this.TitleRatioButton_CheckedChanged);
            // 
            // DiffRatioButton
            // 
            this.DiffRatioButton.AutoSize = true;
            this.DiffRatioButton.Checked = true;
            this.DiffRatioButton.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiffRatioButton.ForeColor = System.Drawing.Color.White;
            this.DiffRatioButton.Location = new System.Drawing.Point(3, 4);
            this.DiffRatioButton.Name = "DiffRatioButton";
            this.DiffRatioButton.Size = new System.Drawing.Size(90, 23);
            this.DiffRatioButton.TabIndex = 0;
            this.DiffRatioButton.TabStop = true;
            this.DiffRatioButton.Text = "Difficulty";
            this.DiffRatioButton.UseVisualStyleBackColor = true;
            this.DiffRatioButton.CheckedChanged += new System.EventHandler(this.DiffRatioButton_CheckedChanged);
            // 
            // CaseSensitive
            // 
            this.CaseSensitive.AutoSize = true;
            this.CaseSensitive.Checked = true;
            this.CaseSensitive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CaseSensitive.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CaseSensitive.ForeColor = System.Drawing.Color.White;
            this.CaseSensitive.Location = new System.Drawing.Point(43, 65);
            this.CaseSensitive.Name = "CaseSensitive";
            this.CaseSensitive.Size = new System.Drawing.Size(108, 19);
            this.CaseSensitive.TabIndex = 14;
            this.CaseSensitive.Text = "Case sensitive";
            this.CaseSensitive.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1180, 435);
            this.Controls.Add(this.CaseSensitive);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelShow);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SensitiveBox);
            this.Controls.Add(this.DiffBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FileList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "osuEZMapsRemover";
            this.Load += new System.EventHandler(this.Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton DiffRatioButton;
        private System.Windows.Forms.RadioButton CreatorRatioButton;
        private System.Windows.Forms.RadioButton TitleRatioButton;
        private System.Windows.Forms.CheckBox CaseSensitive;
    }
}