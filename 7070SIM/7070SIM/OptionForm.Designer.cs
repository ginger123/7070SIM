namespace _7070SIM
{
    partial class OptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.OK_check_but = new System.Windows.Forms.Button();
            this.lebal_option_1 = new System.Windows.Forms.Label();
            this.on_off_picture1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.on_off_picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // OK_check_but
            // 
            this.OK_check_but.Location = new System.Drawing.Point(322, 202);
            this.OK_check_but.Name = "OK_check_but";
            this.OK_check_but.Size = new System.Drawing.Size(75, 23);
            this.OK_check_but.TabIndex = 0;
            this.OK_check_but.Text = "OK";
            this.OK_check_but.UseVisualStyleBackColor = true;
            this.OK_check_but.Click += new System.EventHandler(this.OK_check_but_Click);
            // 
            // lebal_option_1
            // 
            this.lebal_option_1.AutoSize = true;
            this.lebal_option_1.Location = new System.Drawing.Point(13, 31);
            this.lebal_option_1.Name = "lebal_option_1";
            this.lebal_option_1.Size = new System.Drawing.Size(99, 13);
            this.lebal_option_1.TabIndex = 2;
            this.lebal_option_1.Text = "timer in corrent stat:";
            // 
            // on_off_picture1
            // 
            this.on_off_picture1.Image = ((System.Drawing.Image)(resources.GetObject("on_off_picture1.Image")));
            this.on_off_picture1.Location = new System.Drawing.Point(118, 31);
            this.on_off_picture1.Name = "on_off_picture1";
            this.on_off_picture1.Size = new System.Drawing.Size(80, 20);
            this.on_off_picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.on_off_picture1.TabIndex = 1;
            this.on_off_picture1.TabStop = false;
            this.on_off_picture1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.on_off_picture1_MouseDown);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 237);
            this.Controls.Add(this.lebal_option_1);
            this.Controls.Add(this.on_off_picture1);
            this.Controls.Add(this.OK_check_but);
            this.Name = "OptionForm";
            this.Text = "OptionForm";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.on_off_picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_check_but;
        private System.Windows.Forms.PictureBox on_off_picture1;
        private System.Windows.Forms.Label lebal_option_1;
    }
}