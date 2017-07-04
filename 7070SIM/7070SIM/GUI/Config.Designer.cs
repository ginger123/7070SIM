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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.save_path_here = new System.Windows.Forms.TextBox();
            this.file_path_here = new System.Windows.Forms.TextBox();
            this.Confirm_file_pick = new System.Windows.Forms.Button();
            this.OK_TO_GO = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label_save = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_test = new System.Windows.Forms.ListBox();
            this.TRX_Title = new System.Windows.Forms.Label();
            this.ANTS_Title = new System.Windows.Forms.Label();
            this.GPS_Title = new System.Windows.Forms.Label();
            this.ADCS_Title = new System.Windows.Forms.Label();
            this.EPS_Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(881, 400);
            this.tableLayoutPanel3.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.save_path_here, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.file_path_here, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Confirm_file_pick, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.OK_TO_GO, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(875, 194);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // save_path_here
            // 
            this.save_path_here.BackColor = System.Drawing.Color.Red;
            this.save_path_here.Dock = System.Windows.Forms.DockStyle.Top;
            this.save_path_here.Location = new System.Drawing.Point(3, 131);
            this.save_path_here.Name = "save_path_here";
            this.save_path_here.ReadOnly = true;
            this.save_path_here.Size = new System.Drawing.Size(285, 20);
            this.save_path_here.TabIndex = 9;
            this.save_path_here.Click += new System.EventHandler(this.save_path_here_Click);
            // 
            // file_path_here
            // 
            this.file_path_here.BackColor = System.Drawing.SystemColors.Window;
            this.file_path_here.Dock = System.Windows.Forms.DockStyle.Top;
            this.file_path_here.Location = new System.Drawing.Point(294, 67);
            this.file_path_here.Name = "file_path_here";
            this.file_path_here.ReadOnly = true;
            this.file_path_here.Size = new System.Drawing.Size(285, 20);
            this.file_path_here.TabIndex = 6;
            // 
            // Confirm_file_pick
            // 
            this.Confirm_file_pick.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Confirm_file_pick.Location = new System.Drawing.Point(294, 30);
            this.Confirm_file_pick.Name = "Confirm_file_pick";
            this.Confirm_file_pick.Size = new System.Drawing.Size(285, 31);
            this.Confirm_file_pick.TabIndex = 5;
            this.Confirm_file_pick.Text = "Confirm File";
            this.Confirm_file_pick.UseVisualStyleBackColor = true;
            this.Confirm_file_pick.Click += new System.EventHandler(this.Confirm_file_pick_Click);
            // 
            // OK_TO_GO
            // 
            this.OK_TO_GO.Dock = System.Windows.Forms.DockStyle.Top;
            this.OK_TO_GO.Location = new System.Drawing.Point(585, 131);
            this.OK_TO_GO.Name = "OK_TO_GO";
            this.OK_TO_GO.Size = new System.Drawing.Size(287, 23);
            this.OK_TO_GO.TabIndex = 7;
            this.OK_TO_GO.Text = "OK";
            this.OK_TO_GO.UseVisualStyleBackColor = true;
            this.OK_TO_GO.Click += new System.EventHandler(this.OK_TO_GO_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.68421F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.31579F));
            this.tableLayoutPanel4.Controls.Add(this.label_save, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(285, 58);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // label_save
            // 
            this.label_save.AutoSize = true;
            this.label_save.BackColor = System.Drawing.Color.Red;
            this.label_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_save.ForeColor = System.Drawing.Color.Black;
            this.label_save.Location = new System.Drawing.Point(3, 45);
            this.label_save.Name = "label_save";
            this.label_save.Size = new System.Drawing.Size(32, 13);
            this.label_save.TabIndex = 21;
            this.label_save.Text = "Save";
            this.label_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_save_MouseDown);
            this.label_save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_save_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.16109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.8791F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.71389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.22582F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.02009F));
            this.tableLayoutPanel1.Controls.Add(this.listBox_test, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TRX_Title, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ANTS_Title, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.GPS_Title, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ADCS_Title, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.EPS_Title, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.97917F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.6875F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 194);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // listBox_test
            // 
            this.listBox_test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_test.FormattingEnabled = true;
            this.listBox_test.Items.AddRange(new object[] {
            "ok",
            "lets",
            "do",
            "it",
            "red",
            "green (lime)"});
            this.listBox_test.Location = new System.Drawing.Point(3, 37);
            this.listBox_test.Name = "listBox_test";
            this.listBox_test.Size = new System.Drawing.Size(152, 154);
            this.listBox_test.TabIndex = 23;
            this.listBox_test.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_test_MouseClick);
            // 
            // TRX_Title
            // 
            this.TRX_Title.AutoSize = true;
            this.TRX_Title.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TRX_Title.Location = new System.Drawing.Point(161, 21);
            this.TRX_Title.Name = "TRX_Title";
            this.TRX_Title.Size = new System.Drawing.Size(185, 13);
            this.TRX_Title.TabIndex = 1;
            this.TRX_Title.Text = "TRX";
            // 
            // ANTS_Title
            // 
            this.ANTS_Title.AutoSize = true;
            this.ANTS_Title.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ANTS_Title.Location = new System.Drawing.Point(352, 21);
            this.ANTS_Title.Name = "ANTS_Title";
            this.ANTS_Title.Size = new System.Drawing.Size(157, 13);
            this.ANTS_Title.TabIndex = 2;
            this.ANTS_Title.Text = "ANTS";
            // 
            // GPS_Title
            // 
            this.GPS_Title.AutoSize = true;
            this.GPS_Title.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GPS_Title.Location = new System.Drawing.Point(515, 21);
            this.GPS_Title.Name = "GPS_Title";
            this.GPS_Title.Size = new System.Drawing.Size(179, 13);
            this.GPS_Title.TabIndex = 3;
            this.GPS_Title.Text = "GPS";
            // 
            // ADCS_Title
            // 
            this.ADCS_Title.AutoSize = true;
            this.ADCS_Title.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ADCS_Title.Location = new System.Drawing.Point(700, 21);
            this.ADCS_Title.Name = "ADCS_Title";
            this.ADCS_Title.Size = new System.Drawing.Size(172, 13);
            this.ADCS_Title.TabIndex = 4;
            this.ADCS_Title.Text = "ADCS";
            // 
            // EPS_Title
            // 
            this.EPS_Title.AutoSize = true;
            this.EPS_Title.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EPS_Title.Location = new System.Drawing.Point(3, 21);
            this.EPS_Title.Name = "EPS_Title";
            this.EPS_Title.Size = new System.Drawing.Size(152, 13);
            this.EPS_Title.TabIndex = 0;
            this.EPS_Title.Text = "EPS";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 400);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_save;
        private System.Windows.Forms.TextBox save_path_here;
        private System.Windows.Forms.TextBox file_path_here;
        private System.Windows.Forms.Button Confirm_file_pick;
        private System.Windows.Forms.Button OK_TO_GO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox_test;
        private System.Windows.Forms.Label TRX_Title;
        private System.Windows.Forms.Label ANTS_Title;
        private System.Windows.Forms.Label GPS_Title;
        private System.Windows.Forms.Label ADCS_Title;
        private System.Windows.Forms.Label EPS_Title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}