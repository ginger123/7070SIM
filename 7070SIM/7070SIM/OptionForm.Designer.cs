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
            this.save_action_button = new System.Windows.Forms.PictureBox();
            this.on_off_picture1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.save_action_button)).BeginInit();
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
            this.label_option_2.Location = new System.Drawing.Point(13, 179);
            this.label_option_2.Name = "label_option_2";
            this.label_option_2.Size = new System.Drawing.Size(68, 13);
            this.label_option_2.TabIndex = 4;
            this.label_option_2.Text = "save_action:";
            // 
            // save_action_button
            // 
            this.save_action_button.Image = ((System.Drawing.Image)(resources.GetObject("save_action_button.Image")));
            this.save_action_button.Location = new System.Drawing.Point(118, 179);
            this.save_action_button.Name = "save_action_button";
            this.save_action_button.Size = new System.Drawing.Size(80, 20);
            this.save_action_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.save_action_button.TabIndex = 3;
            this.save_action_button.TabStop = false;
            this.save_action_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.save_action_button_MouseDown);
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
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 237);
            this.Controls.Add(this.label_option_2);
            this.Controls.Add(this.save_action_button);
            this.Controls.Add(this.label_option_1);
            this.Controls.Add(this.on_off_picture1);
            this.Controls.Add(this.OK_check_but);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionForm";
            this.Text = "OptionForm";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.save_action_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_off_picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_check_but;
        private System.Windows.Forms.PictureBox on_off_picture1;
        private System.Windows.Forms.Label label_option_1;
        private System.Windows.Forms.Label label_option_2;
        private System.Windows.Forms.PictureBox save_action_button;
    }
}