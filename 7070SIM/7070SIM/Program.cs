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
            Option.main();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Config());
            if (Config.ok_buttom == true)
            {
                Application.Run(new Corrent_Stat());
                DateTime localDate = DateTime.Now;
                try
                {
                    using (StreamWriter sw = File.CreateText(Option.option_path))
                    {
                        for (int i = 0; i < Option.HMO; i++)
                            sw.Write("{0}={1}\n", Option.label_name[i], Option.check_opt[i]);

                        int firstCharacter = Config.folderName.IndexOf(@"\Sutalite_sims");

                        if (firstCharacter != -1)
                            sw.Write("auto_path_save={0}\n", (Config.folderName));
                        else
                            sw.Write("auto_path_save={0}\n", (Config.folderName + @"\" + @"Sutalite_sims"));
                    }
                }
                catch
                {
                    System.IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Sutalite_sims");
                    using (StreamWriter sw = File.CreateText(Option.option_path))
                    {
                        for (int i = 0; i < Option.HMO; i++)
                            sw.Write("{0}={1}\n", Option.label_name[i], Option.check_opt[i]);

                        int firstCharacter = Config.folderName.IndexOf(@"\Sutalite_sims");

                        if (firstCharacter != -1)
                            sw.Write("auto_path_save={0}\n", (Config.folderName));
                        else
                            sw.Write("auto_path_save={0}\n", (Config.folderName + @"\Sutalite_sims"));
                    }
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
                    if (Config.folderName.IndexOf(@"\Sutalite_sims") == -1)
                        System.IO.Directory.CreateDirectory(Config.folderName + @"\Sutalite_sims");
                    else
                        System.IO.Directory.CreateDirectory(Config.folderName);

                    if ((Config.path_in_textbox == "") && (Config.folderName.IndexOf(@"\Sutalite_sims") == -1))
                    {
                        path_log = Config.folderName + @"\" + @"Sutalite_sims\" + "D" + localDate.Day + "." + "M" + localDate.Month + "-" + "H" + localDate.Hour + "." + "M" + localDate.Minute + ".Data";
                    }
                    else
                    {
                        path_log = Config.folderName + @"\" + "D" + localDate.Day + "." + "M" + localDate.Month + "-" + "H" + localDate.Hour + "." + "M" + localDate.Minute + ".Data";
                    }
                    //------------------------------------------------------------------
                    string in_side_name_file = "D" + localDate.Day + "." + "M" + localDate.Month + "-" + "H" + localDate.Hour + "." + "M" + localDate.Minute;
                    //------------------------------------------------------------------
                    try
                    {
                        if (File.ReadAllText(Config.path_in_textbox) != "")
                        {
                            using (StreamWriter sw = File.CreateText(Config.path_in_textbox))
                            {
                                sw.Write("");
                            }
                            using (StreamWriter sw = File.AppendText(Config.path_in_textbox))
                            {
                                sw.Write(Corrent_Stat.suffix.Substring(0 , Corrent_Stat.suffix.Length - 18));
                                sw.Write(Environment.NewLine + "---@new_log@---" + Environment.NewLine + "New log starts here: with the name: " + in_side_name_file + Environment.NewLine + "---@new_log@---" + Environment.NewLine + Environment.NewLine);
                                sw.Write(Corrent_Stat.testing_reciving_text);
                            }
                            if (Option.check_opt[2] == true)
                                MessageBox.Show("Update Log in : " + Config.path_in_textbox, "Before closing...");
                        }
                    }
                    catch
                    {
                        using (StreamWriter sw = File.CreateText(path_log))
                        {
                            sw.Write("New Log, Name: " + path_log + Environment.NewLine + Corrent_Stat.testing_reciving_text);
                        }
                        if (Option.check_opt[2] == true)
                            MessageBox.Show("Made Log in : " + path_log, "Before closing...");
                    }
                    
                    //------------------------------------------------------------------
                }
                else
                    if (Option.check_opt[2] == true)
                        MessageBox.Show("You Didn't save...", ":(");
            }
        }
    }

}
