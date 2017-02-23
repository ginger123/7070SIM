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
            if (Config.ok_buttom == true)
            {
                Application.Run(new Corrent_Stat());
                DateTime localDate = DateTime.Now;
                if (true)
                {
                    if (Config.option_path == "")
                    {
                        string desktoplocate = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string path;
                        path = Config.folderName + desktoplocate + @"\" + "option" + ".txt";
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.Write("static_time:{0}", OptionForm.check_opt1);
                        }
                    }
                }
                if (Config.saveornotint == true)
                {
                    if (Config.path_in_textbox != "")
                    {
                        string path;
                        path = Config.folderName + @"\" + "D" + localDate.Day + "." + "M" + localDate.Month + "-" + "H" + localDate.Hour + "." + "M" + localDate.Minute + ".txt";
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.Write(TEXT_test.testing_reciving_text);
                        }
                        MessageBox.Show("Made Log in : " + path, "Before closing...");
                    }
                    else
                        MessageBox.Show("You Didn't type where to save it...", ":(");
                }
                else
                    MessageBox.Show("You Didn't save...", ":(");
            }
        }
    }

}
