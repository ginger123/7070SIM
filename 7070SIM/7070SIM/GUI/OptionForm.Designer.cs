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
        private void InitializeComponent(int get_buttom_num)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.OK_check_but = new System.Windows.Forms.Button();
            for (int i = 0; i < get_buttom_num; i++)
            {
                this.on_off_picture[i] = new System.Windows.Forms.PictureBox();
                this.label[i] = new System.Windows.Forms.Label();
                ((System.ComponentModel.ISupportInitialize)(this.on_off_picture[i])).BeginInit();
            }
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

            for (int i = 0; i < get_buttom_num; i++)
            {
                // 
                // label[]
                // 
                this.label[i].AutoSize = true;
                this.label[i].Location = new System.Drawing.Point(13, 31  * (i + 1));
                this.label[i].Name = "label_option_" + i;
                this.label[i].Size = new System.Drawing.Size(99, 13);
                this.label[i].TabIndex = 2;
                // 
                // on_off_picture[]
                // 
                this.on_off_picture[i].Image = ((System.Drawing.Image)(resources.GetObject("on_off_picture2.Image")));
                this.on_off_picture[i].Location = new System.Drawing.Point(13 + 99 + 5, 30 * (i + 1));
                this.on_off_picture[i].Name = "on_off_picture_" + i;
                this.on_off_picture[i].Size = new System.Drawing.Size(80, 20);
                this.on_off_picture[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                this.on_off_picture[i].TabIndex = 3;
                this.on_off_picture[i].TabStop = false;
                this.on_off_picture[i].MouseDown += new System.Windows.Forms.MouseEventHandler(this.on_off_picture_clicked);
            }
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 237);
            this.Controls.Add(this.OK_check_but);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionForm";
            this.Text = "OptionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionForm_FormClosed);
            this.Load += new System.EventHandler(this.OptionForm_Load);
            for (int i = 0; i < get_buttom_num; i++)
            {
                this.Controls.Add(this.label[i]);
                this.Controls.Add(this.on_off_picture[i]);
                ((System.ComponentModel.ISupportInitialize)(this.on_off_picture[i])).EndInit();
            }
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_check_but;
    }
}