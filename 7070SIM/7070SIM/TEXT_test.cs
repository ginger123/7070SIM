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
        public TEXT_test()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Corrent_Stat.testing_reciving_text = textBox1.Text;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
            textBox1.Refresh();
        }
        private Timer timer1;
        private void TEXT_test_Load(object sender, EventArgs e)
        {
            //testing_reciving_text = "im logger, nice to meet you";
            textBox1.ScrollBars = ScrollBars.Vertical;
            timer1 = new Timer();
            timer1.Tick += new EventHandler(refrash_text);
            timer1.Interval = 20; //aka tick
            timer1.Start();
            textBox1.Text = Corrent_Stat.testing_reciving_text;
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
            for (int i = 0; i <= 10; i++)
            {
                DateTime localDate = DateTime.Now;
                string time_date,minit,hours,secends;

                if (localDate.Second < 10)
                    secends = "0" + localDate.Second;
                else
                    secends = "" + localDate.Second;

                if (localDate.Minute < 10)
                    minit = "0" + localDate.Minute;
                else
                    minit = "" + localDate.Minute;

                if (localDate.Hour < 10)
                    hours = "0" + localDate.Hour;
                else
                    hours = "" + localDate.Hour;

                time_date = "<" + hours + ":" + minit + ":" + secends + ">";
                int before = rnd.Next(1, 6);
                int int_random = rnd.Next(1000, 9999);
                if (before == 1)
                    textBox1.Text += time_date + "EPS" + " : " + int_random + Environment.NewLine;
                if (before == 2)
                    textBox1.Text += time_date + "TRX" + " : " + int_random + Environment.NewLine;
                if (before == 3)
                    textBox1.Text += time_date + "ANTS" + " : " + int_random + Environment.NewLine;
                if (before == 4)
                    textBox1.Text += time_date + "GPS" + " : " + int_random + Environment.NewLine;
                if (before == 5)
                    textBox1.Text += time_date + "ADCS" + " : " + int_random + Environment.NewLine;
            }
        }
    }
}
