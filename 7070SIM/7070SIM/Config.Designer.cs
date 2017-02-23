﻿namespace _7070SIM
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.EPS_Title = new System.Windows.Forms.Label();
            this.TRX_Title = new System.Windows.Forms.Label();
            this.ANTS_Title = new System.Windows.Forms.Label();
            this.GPS_Title = new System.Windows.Forms.Label();
            this.ADCS_Title = new System.Windows.Forms.Label();
            this.Confirm_file_pick = new System.Windows.Forms.Button();
            this.file_path_here = new System.Windows.Forms.TextBox();
            this.OK_TO_GO = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.save_path_here = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label_save = new System.Windows.Forms.Label();
            this.listBox_test = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.option_file_here = new System.Windows.Forms.TextBox();
            this.option_confirm = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EPS_Title
            // 
            this.EPS_Title.AutoSize = true;
            this.EPS_Title.Location = new System.Drawing.Point(123, 74);
            this.EPS_Title.Name = "EPS_Title";
            this.EPS_Title.Size = new System.Drawing.Size(28, 13);
            this.EPS_Title.TabIndex = 0;
            this.EPS_Title.Text = "EPS";
            // 
            // TRX_Title
            // 
            this.TRX_Title.AutoSize = true;
            this.TRX_Title.Location = new System.Drawing.Point(362, 74);
            this.TRX_Title.Name = "TRX_Title";
            this.TRX_Title.Size = new System.Drawing.Size(29, 13);
            this.TRX_Title.TabIndex = 1;
            this.TRX_Title.Text = "TRX";
            // 
            // ANTS_Title
            // 
            this.ANTS_Title.AutoSize = true;
            this.ANTS_Title.Location = new System.Drawing.Point(694, 74);
            this.ANTS_Title.Name = "ANTS_Title";
            this.ANTS_Title.Size = new System.Drawing.Size(36, 13);
            this.ANTS_Title.TabIndex = 2;
            this.ANTS_Title.Text = "ANTS";
            // 
            // GPS_Title
            // 
            this.GPS_Title.AutoSize = true;
            this.GPS_Title.Location = new System.Drawing.Point(1015, 74);
            this.GPS_Title.Name = "GPS_Title";
            this.GPS_Title.Size = new System.Drawing.Size(29, 13);
            this.GPS_Title.TabIndex = 3;
            this.GPS_Title.Text = "GPS";
            // 
            // ADCS_Title
            // 
            this.ADCS_Title.AutoSize = true;
            this.ADCS_Title.Location = new System.Drawing.Point(1304, 74);
            this.ADCS_Title.Name = "ADCS_Title";
            this.ADCS_Title.Size = new System.Drawing.Size(36, 13);
            this.ADCS_Title.TabIndex = 4;
            this.ADCS_Title.Text = "ADCS";
            // 
            // Confirm_file_pick
            // 
            this.Confirm_file_pick.Location = new System.Drawing.Point(552, 451);
            this.Confirm_file_pick.Name = "Confirm_file_pick";
            this.Confirm_file_pick.Size = new System.Drawing.Size(475, 31);
            this.Confirm_file_pick.TabIndex = 5;
            this.Confirm_file_pick.Text = "Confirm File";
            this.Confirm_file_pick.UseVisualStyleBackColor = true;
            this.Confirm_file_pick.Click += new System.EventHandler(this.Confirm_file_pick_Click);
            // 
            // file_path_here
            // 
            this.file_path_here.BackColor = System.Drawing.SystemColors.Window;
            this.file_path_here.Location = new System.Drawing.Point(552, 489);
            this.file_path_here.Name = "file_path_here";
            this.file_path_here.ReadOnly = true;
            this.file_path_here.Size = new System.Drawing.Size(475, 20);
            this.file_path_here.TabIndex = 6;
            // 
            // OK_TO_GO
            // 
            this.OK_TO_GO.Location = new System.Drawing.Point(1291, 509);
            this.OK_TO_GO.Name = "OK_TO_GO";
            this.OK_TO_GO.Size = new System.Drawing.Size(75, 23);
            this.OK_TO_GO.TabIndex = 7;
            this.OK_TO_GO.Text = "OK";
            this.OK_TO_GO.UseVisualStyleBackColor = true;
            this.OK_TO_GO.Click += new System.EventHandler(this.OK_TO_GO_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // save_path_here
            // 
            this.save_path_here.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save_path_here.BackColor = System.Drawing.Color.Red;
            this.save_path_here.Location = new System.Drawing.Point(12, 512);
            this.save_path_here.Name = "save_path_here";
            this.save_path_here.ReadOnly = true;
            this.save_path_here.Size = new System.Drawing.Size(417, 20);
            this.save_path_here.TabIndex = 9;
            this.save_path_here.Click += new System.EventHandler(this.save_path_here_Click);
            // 
            // label_save
            // 
            this.label_save.AutoSize = true;
            this.label_save.BackColor = System.Drawing.Color.Red;
            this.label_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_save.ForeColor = System.Drawing.Color.Black;
            this.label_save.Location = new System.Drawing.Point(36, 480);
            this.label_save.Name = "label_save";
            this.label_save.Size = new System.Drawing.Size(32, 13);
            this.label_save.TabIndex = 21;
            this.label_save.Text = "Save";
            this.label_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_save_MouseDown);
            this.label_save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_save_MouseUp);
            // 
            // listBox_test
            // 
            this.listBox_test.FormattingEnabled = true;
            this.listBox_test.Items.AddRange(new object[] {
            "ok",
            "lets",
            "do",
            "it",
            "red",
            "green (lime)"});
            this.listBox_test.Location = new System.Drawing.Point(76, 90);
            this.listBox_test.Name = "listBox_test";
            this.listBox_test.Size = new System.Drawing.Size(120, 95);
            this.listBox_test.TabIndex = 23;
            this.listBox_test.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_test_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 469);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 37);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // option_file_here
            // 
            this.option_file_here.BackColor = System.Drawing.SystemColors.Window;
            this.option_file_here.Location = new System.Drawing.Point(735, 515);
            this.option_file_here.Name = "option_file_here";
            this.option_file_here.ReadOnly = true;
            this.option_file_here.Size = new System.Drawing.Size(292, 20);
            this.option_file_here.TabIndex = 25;
            // 
            // option_confirm
            // 
            this.option_confirm.Location = new System.Drawing.Point(553, 515);
            this.option_confirm.Name = "option_confirm";
            this.option_confirm.Size = new System.Drawing.Size(176, 20);
            this.option_confirm.TabIndex = 24;
            this.option_confirm.Text = "option_file";
            this.option_confirm.UseVisualStyleBackColor = true;
            this.option_confirm.Click += new System.EventHandler(this.option_confirm_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 582);
            this.Controls.Add(this.option_file_here);
            this.Controls.Add(this.option_confirm);
            this.Controls.Add(this.listBox_test);
            this.Controls.Add(this.label_save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.save_path_here);
            this.Controls.Add(this.OK_TO_GO);
            this.Controls.Add(this.file_path_here);
            this.Controls.Add(this.Confirm_file_pick);
            this.Controls.Add(this.ADCS_Title);
            this.Controls.Add(this.GPS_Title);
            this.Controls.Add(this.ANTS_Title);
            this.Controls.Add(this.TRX_Title);
            this.Controls.Add(this.EPS_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EPS_Title;
        private System.Windows.Forms.Label TRX_Title;
        private System.Windows.Forms.Label ANTS_Title;
        private System.Windows.Forms.Label GPS_Title;
        private System.Windows.Forms.Label ADCS_Title;
        private System.Windows.Forms.Button Confirm_file_pick;
        private System.Windows.Forms.TextBox file_path_here;
        private System.Windows.Forms.Button OK_TO_GO;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox save_path_here;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_save;
        private System.Windows.Forms.ListBox listBox_test;
        private System.Windows.Forms.TextBox option_file_here;
        private System.Windows.Forms.Button option_confirm;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}