﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7070SIM
{
    public partial class Logger_window : Form
    {
        public static Timer timekeeper = new Timer();
        public string data_in_logger = TEXT_test.testing_reciving_text;
        public Logger_window()
        {
            InitializeComponent();
        }

        private void LoggerTEXTBOX_TextChanged(object sender, EventArgs e)
        {
            LoggerTEXTBOX.SelectionStart = LoggerTEXTBOX.Text.Length;
            LoggerTEXTBOX.ScrollToCaret();
            LoggerTEXTBOX.Refresh();
        }
        private Timer timer1; 
        private void Logger_window_Load(object sender, EventArgs e)
        {
            LoggerTEXTBOX.ScrollBars = ScrollBars.Vertical;
            if (true)
            {
                timer1 = new Timer();
                timer1.Tick += new EventHandler(refrash_text);
                timer1.Interval = 50;
                timer1.Start();
            }

        }
        private bool howmuchyoubeenthere = true;
        int really_check_it = 0;
        private void refrash_text(object sender, EventArgs e)
        {
            data_in_logger = TEXT_test.testing_reciving_text;
//            LoggerTEXTBOX.Text = data_in_logger + "/n" + "\n" + ";lolololol";
            string[] splitLines = TEXT_test.testing_reciving_text.Split('\n');
            string save_text = "";
            bool check_if_check = false;
            for (int i = 0; i < splitLines.Length; i++)
            {
                if (EPScheckBox.Checked == true)
                {
                    if (splitLines[i].IndexOf("EPS") == 0)
                    {
                        save_text += splitLines[i] + Environment.NewLine;
                    }
                    check_if_check = true;
                }
                if (TRXcheckBox.Checked == true)
                {
                    if (splitLines[i].IndexOf("TRX") == 0)
                    {
                        save_text += splitLines[i] + Environment.NewLine;
                    }
                    check_if_check = true;
                }
                if (ANTScheckBox.Checked == true)
                {
                    if (splitLines[i].IndexOf("ANTS") == 0)
                    {
                        save_text += splitLines[i] + Environment.NewLine;
                    }
                    check_if_check = true;
                }
                if (GPScheckBox.Checked == true)
                {
                    if (splitLines[i].IndexOf("GPS") == 0)
                    {
                        save_text += splitLines[i] + Environment.NewLine;
                    }
                    check_if_check = true;
                }
                if (ADCScheckBox.Checked == true)
                {
                    if (splitLines[i].IndexOf("ADCS") == 0)
                    {
                        save_text += splitLines[i] + Environment.NewLine;
                    }
                    check_if_check = true;
                }
            }
            if (check_if_check == false)
            {
                LoggerTEXTBOX.Text = data_in_logger;
                howmuchyoubeenthere = true;

            }
            else if ((howmuchyoubeenthere == true) || (check_if_check == true))
            {
                LoggerTEXTBOX.Text = save_text;
                howmuchyoubeenthere = false;

            }
        }
    }
}
