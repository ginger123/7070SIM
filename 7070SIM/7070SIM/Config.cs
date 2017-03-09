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
        private int times_click_true = 0, selecting_now = -1;
        private Timer timer1;

        public static bool ok_buttom = false;
        public static string path_in_textbox = "";
        public static string folderName = "";
        public static bool saveornotint = false;

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
            ok_buttom = true;
            path_in_textbox = file_path_here.Text;
            this.Close();
        }
        private void Config_Load(object sender, EventArgs e)
        {
            Option_class.read();
            string[] option_file_text_here = new string[Option_class.HMO];
            try
            {
                option_file_text_here = System.IO.File.ReadAllText(Option_class.option_path).Split('\n');
                if (option_file_text_here[1].IndexOf("True") == 10)
                {
                    saveornotint = true;
                    pictureBox1.Image = Properties.Resources.green;
                    label_save.BackColor = Color.Lime;
                    save_path_here.BackColor = Color.White;
                    save_path_here.Text = option_file_text_here[Option_class.HMO].Substring(15, option_file_text_here[Option_class.HMO].Length - 15);
                    folderName = option_file_text_here[Option_class.HMO].Substring(15, option_file_text_here[Option_class.HMO].Length - 15);
                }
            }
            catch
            { }
            timer1 = new Timer();
            timer1.Tick += new EventHandler(check_on_list);
            timer1.Interval = 50;
            timer1.Start();
            System.IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Sutalite_sims");
        }
        private void save_path_here_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                save_path_here.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void check_on_list(object sender, EventArgs e)
        {
            if ((listBox_test.GetSelected(5)) && (times_click_true == 1))
                listBox_test.BackColor = Color.Red;
            else if ((listBox_test.GetSelected(4)) && (times_click_true == 1))
                listBox_test.BackColor = Color.Lime;
            else if ((listBox_test.SelectedIndex < 4) && (times_click_true == 1))
                listBox_test.BackColor = Color.White;
            if (times_click_true >= 2)
                times_click_true = 0;
            this.Text = "times_click_true" + times_click_true + ";" + "selecting_now" + selecting_now;
        }
        private void switch_button_color_and_staff()
        {
            if (saveornotint == false)
            {
                pictureBox1.Image = Properties.Resources.green;
                label_save.BackColor = Color.Lime;
                save_path_here.BackColor = Color.White;
                saveornotint = true;
                if (save_path_here.Text == "")
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        folderName = folderBrowserDialog1.SelectedPath;
                        save_path_here.Text = folderBrowserDialog1.SelectedPath;
                    }
                }
                return;
            }
            if (saveornotint == true)
            {
                pictureBox1.Image = Properties.Resources.red;
                save_path_here.BackColor = Color.Red;
                label_save.BackColor = Color.Red;
                saveornotint = false;
                return;
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (saveornotint == false)
            {
                pictureBox1.Image = Properties.Resources.red_clicked;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.green_clicked;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch_button_color_and_staff();
        }
        private void label_save_MouseDown(object sender, MouseEventArgs e)
        {
            if (saveornotint == false)
            {
                pictureBox1.Image = Properties.Resources.red_clicked;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.green_clicked;
            }
        }
        private void label_save_MouseUp(object sender, MouseEventArgs e)
        {
            switch_button_color_and_staff();
        }
        private void listBox_test_MouseClick(object sender, MouseEventArgs e)
        {
            if (selecting_now == -1)
            {
                selecting_now = listBox_test.SelectedIndex;
                times_click_true++;
                return;
            }
            else if (selecting_now == listBox_test.SelectedIndex)
            {
                times_click_true++;
                return;
            }
            else
            {
                selecting_now = -1;
                times_click_true = 0;
                return;
            }
        }
        private void option_confirm_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                    System.IO.StreamReader(openFileDialog2.FileName);
                Option_class.option_path = openFileDialog2.FileName;
                sr.Close();
            }
        }
    }


    public partial class Option_class
    {
        public static string option_path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Sutalite_sims" + @"\" + "option.txt";

        public static int HMO = 3; // How_Much_Options

        public static bool[] check_opt = new bool[HMO];

        public static void read()
        {
            Option_class.check_opt[2] = true;
            try
            {
                string[] option_file_text_here = System.IO.File.ReadAllText(option_path).Split('\n');
                if (option_file_text_here[0].IndexOf("True") == 12)
                    Option_class.check_opt[0] = true;
                else
                    Option_class.check_opt[0] = false;

                if (option_file_text_here[1].IndexOf("True") == 10)
                    Option_class.check_opt[1] = true;
                else
                    Option_class.check_opt[1] = false;

                if (option_file_text_here[2].IndexOf("True") == 17)
                    Option_class.check_opt[2] = true;
                else
                    Option_class.check_opt[2] = false;
            }
            catch
            { }
        }

        /// <summer>
        /// 
        /// option.txt in (C:\Users\<user>\Documents\Sutalite_sims\option.txt), to change that change Option_class.option_path
        /// 
        /// check_opt[0] => enable\disable time in corrent stat
        /// check_opt[1] => enable\disable auto save
        /// check_opt[2] => enable\disable save path warning at de end
    }
}
