namespace _7070SIM
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
            this.EPS_Title = new System.Windows.Forms.Label();
            this.TRX_Title = new System.Windows.Forms.Label();
            this.ANTS_Title = new System.Windows.Forms.Label();
            this.GPS_Title = new System.Windows.Forms.Label();
            this.ADCS_Title = new System.Windows.Forms.Label();
            this.Confirm_file_pick = new System.Windows.Forms.Button();
            this.file_path_here = new System.Windows.Forms.TextBox();
            this.OK_TO_GO = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Check_if_save = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // Check_if_save
            // 
            this.Check_if_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Check_if_save.AutoSize = true;
            this.Check_if_save.Location = new System.Drawing.Point(12, 487);
            this.Check_if_save.Name = "Check_if_save";
            this.Check_if_save.Size = new System.Drawing.Size(51, 17);
            this.Check_if_save.TabIndex = 8;
            this.Check_if_save.Text = "Save";
            this.Check_if_save.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 512);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 582);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Check_if_save);
            this.Controls.Add(this.OK_TO_GO);
            this.Controls.Add(this.file_path_here);
            this.Controls.Add(this.Confirm_file_pick);
            this.Controls.Add(this.ADCS_Title);
            this.Controls.Add(this.GPS_Title);
            this.Controls.Add(this.ANTS_Title);
            this.Controls.Add(this.TRX_Title);
            this.Controls.Add(this.EPS_Title);
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
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
        private System.Windows.Forms.CheckBox Check_if_save;
        private System.Windows.Forms.TextBox textBox1;
    }
}