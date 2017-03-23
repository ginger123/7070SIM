using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7070SIM
{
    public partial class OptionForm : Form
    {
        private System.Windows.Forms.PictureBox[] on_off_picture = new System.Windows.Forms.PictureBox[Option.HMO];
        private System.Windows.Forms.Label[] label = new System.Windows.Forms.Label[Option.HMO];
        public OptionForm()
        {
            InitializeComponent(Option.HMO);
            for (int i = 0; i < Option.HMO; i++ )
            {
                this.label[i].Text = Option.label_name[i];
            }
        }
        private Timer timer1;

        private void check_get(object sender, EventArgs e)
        {
            bool[] option_is_check = new bool[Option.HMO];
            for (int i = 0; i<Option.HMO;i++)
            {
                option_is_check[i] = Option.check_opt[i];
            }
        }
        private void OptionForm_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(reload_everyting);
            timer1.Tick += new EventHandler(check_get);
            timer1.Interval = 50;
            timer1.Start();
        }
        private void on_off_picture_clicked(object sender, MouseEventArgs e)
        {
            PictureBox Pb = (PictureBox)sender;
            for (int i = 0; i < Option.HMO; i++)
            {
                if (this.on_off_picture[i].Name == Pb.Name)
                {
                    if (Option.check_opt[i] == true)
                    {
                        Option.check_opt[i] = false;
                    }
                    else if (Option.check_opt[i] == false)
                    {
                        Option.check_opt[i] = true;
                    }
                }
            }
        }
        private void reload_everyting(object sender, EventArgs e)
        {
            for (int i = 0; i < Option.HMO; i++)
            {
                if (Option.check_opt[i] == true)
                {
                    on_off_picture[i].Image = Properties.Resources._2_buttons_on;  
                }
                if (Option.check_opt[i] == false)
                {
                    on_off_picture[i].Image = Properties.Resources._2_buttons_off;
                }
            }
        }

        private void OK_check_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OptionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Corrent_Stat.options_is_open = false;
        }
    }
}
