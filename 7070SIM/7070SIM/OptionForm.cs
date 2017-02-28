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
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }
        public static bool[] check_opt = new bool[2];
        private void OK_check_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void on_off_picture1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((check_opt[0] == true) && (gif_is_work1 == false))
            {
                check_opt[0] = false;
                stoptimer1.Reset();
                return;
            }
            if ((check_opt[0] == false) && (gif_is_work1 == false))
            {
                check_opt[0] = true;
                stoptimer1.Reset();
                return;
            }
        }
        private Timer timer1;
        void change_picture_type(int i, bool imbool)
        {
            if ((i == 0) && (imbool == false))
                on_off_picture1.Image = Properties.Resources._2_buttons_off;
            if ((i == 0) && (imbool == true))
                on_off_picture1.Image = Properties.Resources._2_buttons_on;

            if ((i == 0) && (imbool == false))
                save_action_button.Image = Properties.Resources._2_buttons_off;
            if ((i == 0) && (imbool == true))
                save_action_button.Image = Properties.Resources._2_buttons_on;
        }
        private void OptionForm_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(reload_everyting1);
            timer1.Tick += new EventHandler(reload_everyting2);
            timer1.Interval = 50;
            timer1.Start();
            for (int i = 0; i < check_opt.Length; i++)
            {
                //change_picture_type(i, check_opt[i]);
            }
        }
        bool gif_is_work1 = false;
        bool gif_is_work2 = false;
        void reload_everyting1(object sender, EventArgs e)
        {
            stoptimer1.Start();
            TimeSpan ts = stoptimer1.Elapsed;
            if (check_opt[0] == true)
            {
                if ((ts.TotalMilliseconds <= 1400) && (gif_is_work1 == false))
                {
                    gif_is_work1 = true;
                    on_off_picture1.Image = Properties.Resources._2_gif_buttons_off;
                }
                else if (ts.TotalMilliseconds > 1400)
                {
                    on_off_picture1.Image = Properties.Resources._2_buttons_on;
                    gif_is_work1 = false;
                }
            }
            if (check_opt[0] == false)
            {
                if ((ts.TotalMilliseconds <= 1400) && (gif_is_work1 == false))
                {
                    gif_is_work1 = true;
                    on_off_picture1.Image = Properties.Resources._2_gif_buttons_on;
                }
                else if (ts.TotalMilliseconds > 1400)
                {
                    on_off_picture1.Image = Properties.Resources._2_buttons_off;
                    gif_is_work1 = false;
                }
            }
        }
        void reload_everyting2(object sender, EventArgs e)
        {
            stoptimer2.Start();
            TimeSpan ts = stoptimer2.Elapsed;
            if (check_opt[1] == true)
            {
                if ((ts.TotalMilliseconds <= 1400) && (gif_is_work2 == false))
                {
                    gif_is_work2 = true;
                    save_action_button.Image = Properties.Resources._2_gif_buttons_off;
                }
                else if (ts.TotalMilliseconds > 1400)
                {
                    save_action_button.Image = Properties.Resources._2_buttons_on;
                    gif_is_work2 = false;
                }
            }
            if (check_opt[1] == false)
            {
                if ((ts.TotalMilliseconds <= 1400) && (gif_is_work2 == false))
                {
                    gif_is_work2 = true;
                    save_action_button.Image = Properties.Resources._2_gif_buttons_on;
                }
                else if (ts.TotalMilliseconds > 1400)
                {
                    save_action_button.Image = Properties.Resources._2_buttons_off;
                    gif_is_work2 = false;
                }
            }
        }

        private void save_action_button_MouseDown(object sender, MouseEventArgs e)
        {
            if ((check_opt[1] == true) && (gif_is_work2 == false))
            {
                check_opt[1] = false;
                stoptimer2.Reset();
                return;
            }
            if ((check_opt[1] == false) && (gif_is_work2 == false))
            {
                check_opt[1] = true;
                stoptimer2.Reset();
                return;
            }
        }
        Stopwatch stoptimer1 = new Stopwatch();
        Stopwatch stoptimer2 = new Stopwatch();
    }
}
