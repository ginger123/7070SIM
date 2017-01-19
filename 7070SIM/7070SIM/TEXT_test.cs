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
    public partial class TEXT_test : Form
    {
        public static string testing_reciving_text;
        public TEXT_test()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            testing_reciving_text = textBox1.Text;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
            textBox1.Refresh();
        }
        private Timer timer1;
        private void TEXT_test_Load(object sender, EventArgs e)
        {
            testing_reciving_text = "im logger, nice to meet you";
            textBox1.ScrollBars = ScrollBars.Vertical;
            timer1 = new Timer();
            timer1.Tick += new EventHandler(refrash_text);
            timer1.Interval = 20; //aka tick
            timer1.Start();
        }
        private void refrash_text(object sender, EventArgs e)
        {
 //           textBox1.Text = "";
 //           string[] splitLines = testing_reciving_text[0].Split('\n');
        }

        private void EPS_BUT_Click(object sender, EventArgs e)
        {
            textBox1.Text += "EPS";
        }

        private void TRX_BUT_Click(object sender, EventArgs e)
        {
            textBox1.Text += "TRX";
        }

        private void ANYS_BUT_Click(object sender, EventArgs e)
        {
            textBox1.Text += "ANTS";
        }

        private void GPS_BUT_Click(object sender, EventArgs e)
        {
            textBox1.Text += "GPS";
        }

        private void ADCS_BUT_Click(object sender, EventArgs e)
        {
            textBox1.Text += "ADCS";
        }

        private void Random_1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i <= 3; i++)
            {
                int before = rnd.Next(1, 6);
                int int_random = rnd.Next(1000, 9999);
                if (before == 1)
                    textBox1.Text += "EPS" + " : " + int_random + Environment.NewLine;
                if (before == 2)
                    textBox1.Text += "TRX" + " : " + int_random + Environment.NewLine;
                if (before == 3)
                    textBox1.Text += "ANTS" + " : " + int_random + Environment.NewLine;
                if (before == 4)
                    textBox1.Text += "GPS" + " : " + int_random + Environment.NewLine;
                if (before == 5)
                    textBox1.Text += "ADCS" + " : " + int_random + Environment.NewLine;
            }
        }
    }
}
