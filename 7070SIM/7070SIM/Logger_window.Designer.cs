namespace _7070SIM
{
    partial class Logger_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logger_window));
            this.LoggerTEXTBOX = new System.Windows.Forms.TextBox();
            this.EPScheckBox = new System.Windows.Forms.CheckBox();
            this.TRXcheckBox = new System.Windows.Forms.CheckBox();
            this.ANTScheckBox = new System.Windows.Forms.CheckBox();
            this.GPScheckBox = new System.Windows.Forms.CheckBox();
            this.ADCScheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LoggerTEXTBOX
            // 
            this.LoggerTEXTBOX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoggerTEXTBOX.BackColor = System.Drawing.SystemColors.MenuText;
            this.LoggerTEXTBOX.ForeColor = System.Drawing.Color.Lime;
            this.LoggerTEXTBOX.Location = new System.Drawing.Point(13, 13);
            this.LoggerTEXTBOX.Multiline = true;
            this.LoggerTEXTBOX.Name = "LoggerTEXTBOX";
            this.LoggerTEXTBOX.ReadOnly = true;
            this.LoggerTEXTBOX.Size = new System.Drawing.Size(1281, 557);
            this.LoggerTEXTBOX.TabIndex = 0;
            this.LoggerTEXTBOX.TextChanged += new System.EventHandler(this.LoggerTEXTBOX_TextChanged);
            // 
            // EPScheckBox
            // 
            this.EPScheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EPScheckBox.AutoSize = true;
            this.EPScheckBox.Location = new System.Drawing.Point(1300, 15);
            this.EPScheckBox.Name = "EPScheckBox";
            this.EPScheckBox.Size = new System.Drawing.Size(47, 17);
            this.EPScheckBox.TabIndex = 1;
            this.EPScheckBox.Text = "EPS";
            this.EPScheckBox.UseVisualStyleBackColor = true;
            // 
            // TRXcheckBox
            // 
            this.TRXcheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TRXcheckBox.AutoSize = true;
            this.TRXcheckBox.Location = new System.Drawing.Point(1300, 38);
            this.TRXcheckBox.Name = "TRXcheckBox";
            this.TRXcheckBox.Size = new System.Drawing.Size(48, 17);
            this.TRXcheckBox.TabIndex = 2;
            this.TRXcheckBox.Text = "TRX";
            this.TRXcheckBox.UseVisualStyleBackColor = true;
            // 
            // ANTScheckBox
            // 
            this.ANTScheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ANTScheckBox.AutoSize = true;
            this.ANTScheckBox.Location = new System.Drawing.Point(1300, 61);
            this.ANTScheckBox.Name = "ANTScheckBox";
            this.ANTScheckBox.Size = new System.Drawing.Size(55, 17);
            this.ANTScheckBox.TabIndex = 3;
            this.ANTScheckBox.Text = "ANTS";
            this.ANTScheckBox.UseVisualStyleBackColor = true;
            // 
            // GPScheckBox
            // 
            this.GPScheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GPScheckBox.AutoSize = true;
            this.GPScheckBox.Location = new System.Drawing.Point(1300, 84);
            this.GPScheckBox.Name = "GPScheckBox";
            this.GPScheckBox.Size = new System.Drawing.Size(48, 17);
            this.GPScheckBox.TabIndex = 4;
            this.GPScheckBox.Text = "GPS";
            this.GPScheckBox.UseVisualStyleBackColor = true;
            // 
            // ADCScheckBox
            // 
            this.ADCScheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ADCScheckBox.AutoSize = true;
            this.ADCScheckBox.Location = new System.Drawing.Point(1300, 107);
            this.ADCScheckBox.Name = "ADCScheckBox";
            this.ADCScheckBox.Size = new System.Drawing.Size(55, 17);
            this.ADCScheckBox.TabIndex = 5;
            this.ADCScheckBox.Text = "ADCS";
            this.ADCScheckBox.UseVisualStyleBackColor = true;
            // 
            // Logger_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 582);
            this.Controls.Add(this.ADCScheckBox);
            this.Controls.Add(this.GPScheckBox);
            this.Controls.Add(this.ANTScheckBox);
            this.Controls.Add(this.TRXcheckBox);
            this.Controls.Add(this.EPScheckBox);
            this.Controls.Add(this.LoggerTEXTBOX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Logger_window";
            this.Text = "Logger_window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Logger_window_FormClosed);
            this.Load += new System.EventHandler(this.Logger_window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoggerTEXTBOX;
        private System.Windows.Forms.CheckBox EPScheckBox;
        private System.Windows.Forms.CheckBox TRXcheckBox;
        private System.Windows.Forms.CheckBox ANTScheckBox;
        private System.Windows.Forms.CheckBox GPScheckBox;
        private System.Windows.Forms.CheckBox ADCScheckBox;
    }
}