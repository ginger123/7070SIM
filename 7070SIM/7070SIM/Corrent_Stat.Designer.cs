namespace _7070SIM
{
    partial class Corrent_Stat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corrent_Stat));
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.isReciving_label_output = new System.Windows.Forms.Label();
            this.TxBatter = new System.Windows.Forms.Label();
            this.RxBatter = new System.Windows.Forms.Label();
            this.isPKTPending = new System.Windows.Forms.Label();
            this.isSending = new System.Windows.Forms.Label();
            this.isRecieving = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.isCharging = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inPutPower = new System.Windows.Forms.Label();
            this.Drain = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.inOn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Power = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.isSigacquired = new System.Windows.Forms.Label();
            this.loggerTextBox_on_correntStat = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.makeprobsButton = new System.Windows.Forms.Button();
            this.LoggerTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(1281, 34);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(171, 25);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Location = new System.Drawing.Point(1281, 67);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(171, 25);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1263, 403);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.isReciving_label_output);
            this.tabPage1.Controls.Add(this.TxBatter);
            this.tabPage1.Controls.Add(this.RxBatter);
            this.tabPage1.Controls.Add(this.isPKTPending);
            this.tabPage1.Controls.Add(this.isSending);
            this.tabPage1.Controls.Add(this.isRecieving);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1255, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // isReciving_label_output
            // 
            this.isReciving_label_output.AutoSize = true;
            this.isReciving_label_output.Location = new System.Drawing.Point(75, 45);
            this.isReciving_label_output.Name = "isReciving_label_output";
            this.isReciving_label_output.Size = new System.Drawing.Size(19, 13);
            this.isReciving_label_output.TabIndex = 5;
            this.isReciving_label_output.Text = "-0-";
            // 
            // TxBatter
            // 
            this.TxBatter.AutoSize = true;
            this.TxBatter.Location = new System.Drawing.Point(6, 97);
            this.TxBatter.Name = "TxBatter";
            this.TxBatter.Size = new System.Drawing.Size(47, 13);
            this.TxBatter.TabIndex = 4;
            this.TxBatter.Text = "TxBatter";
            // 
            // RxBatter
            // 
            this.RxBatter.AutoSize = true;
            this.RxBatter.Location = new System.Drawing.Point(6, 84);
            this.RxBatter.Name = "RxBatter";
            this.RxBatter.Size = new System.Drawing.Size(48, 13);
            this.RxBatter.TabIndex = 3;
            this.RxBatter.Text = "RxBatter";
            // 
            // isPKTPending
            // 
            this.isPKTPending.AutoSize = true;
            this.isPKTPending.Location = new System.Drawing.Point(6, 71);
            this.isPKTPending.Name = "isPKTPending";
            this.isPKTPending.Size = new System.Drawing.Size(74, 13);
            this.isPKTPending.TabIndex = 2;
            this.isPKTPending.Text = "isPKTPending";
            // 
            // isSending
            // 
            this.isSending.AutoSize = true;
            this.isSending.Location = new System.Drawing.Point(6, 57);
            this.isSending.Name = "isSending";
            this.isSending.Size = new System.Drawing.Size(53, 13);
            this.isSending.TabIndex = 1;
            this.isSending.Text = "isSending";
            // 
            // isRecieving
            // 
            this.isRecieving.AutoSize = true;
            this.isRecieving.Location = new System.Drawing.Point(6, 45);
            this.isRecieving.Name = "isRecieving";
            this.isRecieving.Size = new System.Drawing.Size(62, 13);
            this.isRecieving.TabIndex = 0;
            this.isRecieving.Text = "isRecieving";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.isCharging);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.inPutPower);
            this.tabPage2.Controls.Add(this.Drain);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1255, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // isCharging
            // 
            this.isCharging.AutoSize = true;
            this.isCharging.BackColor = System.Drawing.Color.Transparent;
            this.isCharging.Location = new System.Drawing.Point(27, 21);
            this.isCharging.Name = "isCharging";
            this.isCharging.Size = new System.Drawing.Size(56, 13);
            this.isCharging.TabIndex = 20;
            this.isCharging.Text = "isCharging";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // inPutPower
            // 
            this.inPutPower.AutoSize = true;
            this.inPutPower.Location = new System.Drawing.Point(22, 144);
            this.inPutPower.Name = "inPutPower";
            this.inPutPower.Size = new System.Drawing.Size(61, 13);
            this.inPutPower.TabIndex = 18;
            this.inPutPower.Text = "inPutPower";
            // 
            // Drain
            // 
            this.Drain.AutoSize = true;
            this.Drain.Location = new System.Drawing.Point(19, 131);
            this.Drain.Name = "Drain";
            this.Drain.Size = new System.Drawing.Size(32, 13);
            this.Drain.TabIndex = 17;
            this.Drain.Text = "Drain";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 65);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(220, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vbatt";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.inOn);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.Power);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1255, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // inOn
            // 
            this.inOn.AutoSize = true;
            this.inOn.Location = new System.Drawing.Point(27, 45);
            this.inOn.Name = "inOn";
            this.inOn.Size = new System.Drawing.Size(28, 13);
            this.inOn.TabIndex = 21;
            this.inOn.Text = "isOn";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(10, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Power
            // 
            this.Power.AutoSize = true;
            this.Power.Location = new System.Drawing.Point(7, 19);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(37, 13);
            this.Power.TabIndex = 1;
            this.Power.Text = "Power";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.isSigacquired);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1255, 377);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // isSigacquired
            // 
            this.isSigacquired.AutoSize = true;
            this.isSigacquired.Location = new System.Drawing.Point(7, 11);
            this.isSigacquired.Name = "isSigacquired";
            this.isSigacquired.Size = new System.Drawing.Size(70, 13);
            this.isSigacquired.TabIndex = 0;
            this.isSigacquired.Text = "isSigacquired";
            // 
            // loggerTextBox_on_correntStat
            // 
            this.loggerTextBox_on_correntStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.loggerTextBox_on_correntStat.BackColor = System.Drawing.SystemColors.MenuText;
            this.loggerTextBox_on_correntStat.ForeColor = System.Drawing.Color.Lime;
            this.loggerTextBox_on_correntStat.Location = new System.Drawing.Point(12, 422);
            this.loggerTextBox_on_correntStat.Multiline = true;
            this.loggerTextBox_on_correntStat.Name = "loggerTextBox_on_correntStat";
            this.loggerTextBox_on_correntStat.ReadOnly = true;
            this.loggerTextBox_on_correntStat.Size = new System.Drawing.Size(1263, 137);
            this.loggerTextBox_on_correntStat.TabIndex = 3;
            this.loggerTextBox_on_correntStat.TextChanged += new System.EventHandler(this.loggerTextBox_on_correntStat_TextChanged);
            this.loggerTextBox_on_correntStat.DoubleClick += new System.EventHandler(this.loggerTextBox_on_correntStat_DoubleClick);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(1282, 99);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(170, 25);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // makeprobsButton
            // 
            this.makeprobsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.makeprobsButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.makeprobsButton.Enabled = false;
            this.makeprobsButton.Location = new System.Drawing.Point(1282, 131);
            this.makeprobsButton.Name = "makeprobsButton";
            this.makeprobsButton.Size = new System.Drawing.Size(170, 25);
            this.makeprobsButton.TabIndex = 5;
            this.makeprobsButton.Text = "Make Probs";
            this.makeprobsButton.UseVisualStyleBackColor = false;
            // 
            // LoggerTitle
            // 
            this.LoggerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoggerTitle.AutoSize = true;
            this.LoggerTitle.Location = new System.Drawing.Point(1215, 425);
            this.LoggerTitle.Name = "LoggerTitle";
            this.LoggerTitle.Size = new System.Drawing.Size(40, 13);
            this.LoggerTitle.TabIndex = 6;
            this.LoggerTitle.Text = "Logger";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1414, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ginger";
            // 
            // Corrent_Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoggerTitle);
            this.Controls.Add(this.makeprobsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loggerTextBox_on_correntStat);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Corrent_Stat";
            this.Text = "Corrent Stat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox loggerTextBox_on_correntStat;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button makeprobsButton;
        private System.Windows.Forms.Label LoggerTitle;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxBatter;
        private System.Windows.Forms.Label RxBatter;
        private System.Windows.Forms.Label isPKTPending;
        private System.Windows.Forms.Label isSending;
        private System.Windows.Forms.Label isRecieving;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label inPutPower;
        private System.Windows.Forms.Label Drain;
        private System.Windows.Forms.Label Power;
        private System.Windows.Forms.Label isSigacquired;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label isCharging;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label inOn;
        private System.Windows.Forms.Label isReciving_label_output;
    }
}

