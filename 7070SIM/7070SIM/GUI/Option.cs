using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7070SIM
{
    class Option
    {
        private static string paths = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Sutalite_sims" + @"\" + "option.txt";
        public static string option_path // Option txt location
        {
            get { return paths; }
            private set { paths = value;  }
        }

        private static int How_Much_Options = 3;
        public static int HMO // How_Much_Options
        {
            get { return How_Much_Options; }
            private set { How_Much_Options = value; }
        }

        private static string[] names = new string[] { "enable time in corrent stat", "enable auto saver", "enable save path warning"};
        public static string[] label_name // The option name in the label & save txt
        {
            get { return names; }
            private set { names = value; }
        }

        public static bool[] check_opt = new bool[HMO];

        public static void main() // Set the Option
        {
            Option.check_opt[2] = true;
            try
            {
                for (int i = 0; i < HMO; i++ )
                    if (in_option_search(i, "True", Option.label_name[i].Length + 1))
                        Option.check_opt[i] = true;
                    else
                        Option.check_opt[i] = false;
            }
            catch
            { }
        }

        public static bool in_option_search(int Line, string Index, int Place_In_Line) // Fast search in Option txt
        {
            string[] option_file_text_here = new string[Option.HMO];
            try
            {
                option_file_text_here = System.IO.File.ReadAllText(Option.option_path).Split('\n');
                if (option_file_text_here[Line].IndexOf(Index) == Place_In_Line)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summer>
        /// 
        /// option.txt in (C:\Users\<user>\Documents\Sutalite_sims\option.txt), to change that change Option.option_path
        /// 
        /// check_opt[0] => enable\disable time in corrent stat
        /// check_opt[1] => enable\disable auto save
        /// check_opt[2] => enable\disable save path warning at de end
    }
}
