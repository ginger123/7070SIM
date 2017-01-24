using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace _7070SIM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Config());
            Application.Run(new Corrent_Stat());
            DateTime localDate = DateTime.Now;
            if (Config.saveornotint == 1)
            {
                string path = @"C:\Users\user1\Desktop\" + "D" + localDate.Day + "." + "M" + localDate.Month + "-" + "H" + localDate.Hour + "." + "M" + localDate.Minute + ".txt";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(TEXT_test.testing_reciving_text);
                }
                MessageBox.Show("Made Log in : " + path, "Before closing...");
            }
            else
                MessageBox.Show("You Didn't save...", ":(");
        }
    }

}
