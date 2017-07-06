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
    public partial class Logger_window : Form
    {
        public static Timer timekeeper = new Timer();
        public string data_in_logger;
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
            //LoggerTEXTBOX.ScrollBars = ScrollBars.Vertical;
            if (true)
            {
                timer1 = new Timer();
                timer1.Tick += new EventHandler(refrash_text);
                timer1.Interval = 50;
                timer1.Start();
            }

        }
        private void refrash_text(object sender, EventArgs e)
        {
            data_in_logger = Corrent_Stat.suffix + Corrent_Stat.testing_reciving_text;
//            LoggerTEXTBOX.Text = data_in_logger;
//            LoggerTEXTBOX.Text = data_in_logger + "/n" + "\n" + ";lolololol";
            if (data_in_logger != null)
            {
                bool found_somthing = false;
                string[] splitLines = data_in_logger.Split('\r');
                string save_text = "";
                bool check_if_check = false;
                int[] Type_line = new int[splitLines.Length];
                bool[] showing = new bool[splitLines.Length];

                LoggerTEXTBOX.SelectionColor = Color.Lime;

                for (int i = 0; i < splitLines.Length - 1; i++)
                {
                    showing[i] = false;
                    if (i < splitLines.Length - 1)
                    {
                        splitLines[i] = splitLines[i].Replace("\n", "") + "\n";
                    }
                    if (EPScheckBox.Checked == true)
                    {
                        if (splitLines[i].Contains("EPS"))
                        {
                            save_text += splitLines[i];
                            Type_line[i] = which_line_type(splitLines[i]);
                            showing[i] = true;
                        }
                        check_if_check = true;
                    }
                    if (TRXcheckBox.Checked == true)
                    {
                        if (splitLines[i].Contains("TRX"))
                        {
                            save_text += splitLines[i];
                            Type_line[i] = which_line_type(splitLines[i]);
                            showing[i] = true;
                        }
                        check_if_check = true;
                    }
                    if (ANTScheckBox.Checked == true)
                    {
                        if (splitLines[i].Contains("ANTS"))
                        {
                            save_text += splitLines[i];
                            Type_line[i] = which_line_type(splitLines[i]);
                            showing[i] = true;
                        }
                        check_if_check = true;
                    }
                    if (GPScheckBox.Checked == true)
                    {
                        if (splitLines[i].Contains("GPS"))
                        {
                            save_text += splitLines[i];
                            Type_line[i] = which_line_type(splitLines[i]);
                            showing[i] = true;
                        }
                        check_if_check = true;
                    }
                    if (ADCScheckBox.Checked == true)
                    {
                        if (splitLines[i].Contains("ADCS"))
                        {
                            save_text += splitLines[i];
                            Type_line[i] = which_line_type(splitLines[i]);
                            showing[i] = true;
                        }
                        check_if_check = true;
                    }
                    if (search_box.Text != "")
                    {
                        if (splitLines[i].ToLower().Contains(search_box.Text.ToLower()))
                        {
                            search_box.ForeColor = Color.Lime;
                            save_text += splitLines[i];
                            showing[i] = true;
                            Type_line[i] = which_line_type(splitLines[i]);
                            found_somthing = true;
                        }
                        if (found_somthing == false)
                        {
                            search_box.ForeColor = Color.Red;
                        }
                        check_if_check = true;
                    }
                    if (check_if_check == false)
                    {
                        save_text += splitLines[i];
                        showing[i] = true;
                        Type_line[i] = which_line_type(splitLines[i]);
                    }
                }
                if (LoggerTEXTBOX.Text != save_text)
                {
                    LoggerTEXTBOX.Text = save_text;
                    for (int i = 0; i < splitLines.Length - 1; i++)
                    {
                        if (Type_line[i] == 0 && showing[i] == true && LoggerTEXTBOX.Text != "")
                        {
                            LoggerTEXTBOX.Select(LoggerTEXTBOX.Text.IndexOf(splitLines[i]), splitLines[i].Length);
                            if (LoggerTEXTBOX.SelectionColor != Color.Red)
                            {
                                LoggerTEXTBOX.SelectionColor = Color.Red;
                            }
                        }
                        if (Type_line[i] == 1 && showing[i] == true && LoggerTEXTBOX.Text != "")
                        {
                            LoggerTEXTBOX.Select(LoggerTEXTBOX.Text.IndexOf(splitLines[i]), splitLines[i].Length);
                            if (LoggerTEXTBOX.SelectionColor != Color.Lime)
                            {
                                LoggerTEXTBOX.SelectionColor = Color.Lime;
                            }
                        }
                    }
                }
            }
        }

        private void Logger_window_FormClosed(object sender, FormClosedEventArgs e)
        {
            Corrent_Stat.logger_is_open = false;
        }

        private int which_line_type(string text)
        {
            string[] Types = new string[] { "Error" };
            int x = 0;
            for (int i = 0; i < Types.Length; i++)
            {
                if (text.ToLower().Contains(Types[i].ToLower()))
                {
                    switch (Types[i].ToLower())
                    {
                        case "error":
                            x = 0;
                            break;
                        default:
                            x = 1;
                            break;
                    }
                }
                else
                {
                    x = 1;
                }
            }
            return x;
        }
    }
}
