
namespace osuezmapsdelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchB = new System.Windows.Forms.Button();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileList
            // 
            this.FileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(193)))));
            this.FileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileList.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileList.ForeColor = System.Drawing.Color.White;
            this.FileList.Location = new System.Drawing.Point(297, 2);
            this.FileList.Name = "FileList";
            this.FileList.ReadOnly = true;
            this.FileList.Size = new System.Drawing.Size(881, 446);
            this.FileList.TabIndex = 3;
            this.FileList.Text = "";
            this.FileList.WordWrap = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(92, 225);
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
            this.DiffBox.Location = new System.Drawing.Point(62, 96);
            this.DiffBox.Name = "DiffBox";
            this.DiffBox.Size = new System.Drawing.Size(149, 22);
            this.DiffBox.TabIndex = 0;
            // 
            // SensitiveBox
            // 
            this.SensitiveBox.AutoSize = true;
            this.SensitiveBox.Location = new System.Drawing.Point(43, 202);
            this.SensitiveBox.Name = "SensitiveBox";
            this.SensitiveBox.Size = new System.Drawing.Size(180, 17);
            this.SensitiveBox.TabIndex = 1;
            this.SensitiveBox.Text = "I want to delete those beatmaps.";
            this.SensitiveBox.UseVisualStyleBackColor = true;
            this.SensitiveBox.CheckedChanged += new System.EventHandler(this.SensitiveBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(89, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Difficulty name:";
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.White;
            this.SearchB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchB.Location = new System.Drawing.Point(213, 96);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(45, 22);
            this.SearchB.TabIndex = 6;
            this.SearchB.Text = "Show";
            this.SearchB.UseVisualStyleBackColor = false;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(12, 376);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(268, 23);
            this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Click \"Show\" to see the progress.";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SensitiveBox);
            this.Controls.Add(this.DiffBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FileList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "osuEZMapsRemover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FileList;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox DiffBox;
        private System.Windows.Forms.CheckBox SensitiveBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Label label3;
    }
}

