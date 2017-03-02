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
            this.label_option_1 = new System.Windows.Forms.Label();
            this.label_option_2 = new System.Windows.Forms.Label();
            this.on_off_picture2 = new System.Windows.Forms.PictureBox();
            this.on_off_picture1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.on_off_picture3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.on_off_picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_off_picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_off_picture3)).BeginInit();
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
            // label_option_1
            // 
            this.label_option_1.AutoSize = true;
            this.label_option_1.Location = new System.Drawing.Point(13, 31);
            this.label_option_1.Name = "label_option_1";
            this.label_option_1.Size = new System.Drawing.Size(99, 13);
            this.label_option_1.TabIndex = 2;
            this.label_option_1.Text = "timer in corrent stat:";
            // 
            // label_option_2
            // 
            this.label_option_2.AutoSize = true;
            this.label_option_2.Location = new System.Drawing.Point(13, 56);
            this.label_option_2.Name = "label_option_2";
            this.label_option_2.Size = new System.Drawing.Size(68, 13);
            this.label_option_2.TabIndex = 4;
            this.label_option_2.Text = "save_action:";
            // 
            // on_off_picture2
            // 
            this.on_off_picture2.Image = ((System.Drawing.Image)(resources.GetObject("on_off_picture2.Image")));
            this.on_off_picture2.Location = new System.Drawing.Point(118, 56);
            this.on_off_picture2.Name = "on_off_picture2";
            this.on_off_picture2.Size = new System.Drawing.Size(80, 20);
            this.on_off_picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.on_off_picture2.TabIndex = 3;
            this.on_off_picture2.TabStop = false;
            this.on_off_picture2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.on_off_picture2_MouseDown);
            // 
            // on_off_picture1
            // 
            this.on_off_picture1.Image = global::_7070SIM.Properties.Resources.pictureOn;
            this.on_off_picture1.Location = new System.Drawing.Point(118, 31);
            this.on_off_picture1.Name = "on_off_picture1";
            this.on_off_picture1.Size = new System.Drawing.Size(80, 20);
            this.on_off_picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.on_off_picture1.TabIndex = 1;
            this.on_off_picture1.TabStop = false;
            this.on_off_picture1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.on_off_picture1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "save_file_warning:";
            // 
            // on_off_picture3
            // 
            this.on_off_picture3.Image = ((System.Drawing.Image)(resources.GetObject("on_off_picture3.Image")));
            this.on_off_picture3.Location = new System.Drawing.Point(118, 82);
            this.on_off_picture3.Name = "on_off_picture3";
            this.on_off_picture3.Size = new System.Drawing.Size(80, 20);
            this.on_off_picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.on_off_picture3.TabIndex = 5;
            this.on_off_picture3.TabStop = false;
            this.on_off_picture3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.on_off_picture3_MouseDown);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.on_off_picture3);
            this.Controls.Add(this.label_option_2);
            this.Controls.Add(this.on_off_picture2);
            this.Controls.Add(this.label_option_1);
            this.Controls.Add(this.on_off_picture1);
            this.Controls.Add(this.OK_check_but);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionForm";
            this.Text = "OptionForm";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.on_off_picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_off_picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_off_picture3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_check_but;
        private System.Windows.Forms.PictureBox on_off_picture1;
        private System.Windows.Forms.Label label_option_1;
        private System.Windows.Forms.Label label_option_2;
        private System.Windows.Forms.PictureBox on_off_picture2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox on_off_picture3;
    }
}