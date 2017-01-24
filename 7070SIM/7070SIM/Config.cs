using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace _7070SIM
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }
        private void Confirm_file_pick_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                    System.IO.StreamReader(openFileDialog1.FileName);
                file_path_here.Text = openFileDialog1.FileName;
                sr.Close();
            }
        }

        private void OK_TO_GO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static int saveornotint = 0;
        private void save_or_not(object sender, EventArgs e)
        {
            if (Check_if_save.Checked == true)
                saveornotint = 1;
            else
                saveornotint = 0;
        }

        private Timer timer1;
        private void Config_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(save_or_not);
            timer1.Interval = 50;
            timer1.Start();
        }
    }
}
