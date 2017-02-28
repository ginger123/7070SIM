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

                using (StreamWriter sw = File.CreateText(Config.option_path))
                {
                    sw.Write("static_time:{0}\n", OptionForm.check_opt[0]);
                    sw.Write("auto_save:{0}\n", OptionForm.check_opt[1]);

                    int firstCharacter = Config.path_in_textbox.IndexOf(@"\Sutalite_sims");

                    if (firstCharacter != -1)
                        sw.Write("auto_path_save:{0}\n", (Config.path_in_textbox));
                    else
                        sw.Write("auto_path_save:{0}\n", (Config.path_in_textbox + @"\" + @"Sutalite_sims"));
                }

                if ((Config.folderName == "") && (Config.saveornotint == true))
                {
                    MessageBox.Show("you didnt save your log, and now it is gone forever", "feelsbadman");
                }
                else if (Config.saveornotint == true)
                {
                    //------------------------------------------------------------------
                    string path_log, desktoplocate;
                    desktoplocate = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    int firstCharacter = Config.path_in_textbox.IndexOf(@"\Sutalite_sims");

                    if (firstCharacter == -1)
                    {
                        path_log = Config.folderName + @"\" + @"Sutalite_sims\" + "D" + localDate.Day + "." + "M" + localDate.Month + "-" + "H" + localDate.Hour + "." + "M" + localDate.Minute + ".txt";
                        try
                        {
                            System.IO.Directory.CreateDirectory(Config.folderName + @"\Sutalite_sims");
                        }
                        catch
                        {
                        }
                    }
                    else
                        path_log = Config.folderName + @"\" + "D" + localDate.Day + "." + "M" + localDate.Month + "-" + "H" + localDate.Hour + "." + "M" + localDate.Minute + ".txt";
                    //------------------------------------------------------------------
                    if (Config.path_in_textbox == "")
                    {
                        using (StreamWriter sw = File.CreateText(path_log))
                        {
                            sw.Write(TEXT_test.testing_reciving_text);
                        }
                        MessageBox.Show("Made Log in : " + path_log, "Before closing...");
                    }
                    else
                    {
                        using (StreamWriter sw = File.AppendText(path_log))
                        {
                            sw.Write("---@new_log@---" + "\n" + "New log starts here:" + "---@new_log@---" + "\n");
                            sw.Write(TEXT_test.testing_reciving_text);
                        }
                        MessageBox.Show("Made Log in : " + path_log, "Before closing...");
                    }
                    //------------------------------------------------------------------
                }
                else
                    MessageBox.Show("You Didn't save...", ":(");
            }
        }
    }

}
