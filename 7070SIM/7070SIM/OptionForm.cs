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
        public OptionForm()
        {
            InitializeComponent();
        }
        public static bool check_opt1 = true;
        private void OK_check_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void on_off_picture1_MouseDown(object sender, MouseEventArgs e)
        {
            if (check_opt1 == true)
            {
                on_off_picture1.Image = Properties.Resources._2_buttons_off;
                check_opt1 = false;
                return;
            }
            if (check_opt1 == false)
            {
                on_off_picture1.Image = Properties.Resources._2_buttons_on;
                check_opt1 = true;
                return;
            }
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            if (Corrent_Stat.check_opt1_feedback == true)
            {
                on_off_picture1.Image = Properties.Resources._2_buttons_on;
            }
            if (Corrent_Stat.check_opt1_feedback == false)
            {
                on_off_picture1.Image = Properties.Resources._2_buttons_off;
            }
        }
    }
}
