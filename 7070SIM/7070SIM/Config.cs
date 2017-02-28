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
        public static bool ok_buttom = false;
        public static string path_in_textbox = "";
        private void OK_TO_GO_Click(object sender, EventArgs e)
        {
            ok_buttom = true;
            path_in_textbox = save_path_here.Text;
            this.Close();
        }
        public static bool saveornotint = false;
        private Timer timer1;
        private void Config_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(check_on_list);
            timer1.Interval = 50;
            timer1.Start();
            System.IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Sutalite_sims");
            if (option_file_text_here[1].IndexOf("True") == 10)
            {
                saveornotint = true;
                pictureBox1.Image = Properties.Resources.green;
                label_save.BackColor = Color.Lime;
                save_path_here.BackColor = Color.White;
                save_path_here.Text = option_file_text_here[2].Substring(15, option_file_text_here[2].Length - 15);
                path_in_textbox = option_file_text_here[2].Substring(15, option_file_text_here[2].Length - 15);
                folderName = option_file_text_here[2].Substring(15, option_file_text_here[2].Length - 15);
            }
        }
        public static string folderName = "";
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
            if ((listBox_test.GetSelected(5)) && (times_click_true==1))
                listBox_test.BackColor = Color.Red;
            else if ((listBox_test.GetSelected(4))&&(times_click_true==1))
                listBox_test.BackColor = Color.Lime;
            else if ((listBox_test.SelectedIndex<4)&&(times_click_true==1))
                listBox_test.BackColor = Color.White;
            if (times_click_true >= 2)
                times_click_true = 0;
            this.Text = "times_click_true" + times_click_true + ";" + "selecting_now" + selecting_now;
        }
        void switch_button_color_and_staff()
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
        public static string option_path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Sutalite_sims" + @"\" + "option.txt";
        int times_click_true = 0,selecting_now = -1;
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
                option_path = openFileDialog2.FileName;
                sr.Close();
            }
        }
        string[] option_file_text_here = System.IO.File.ReadAllText(Config.option_path).Split('\n');
    }
}
