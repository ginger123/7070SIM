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
        private Timer timer1;
        private bool[] gif_is_work = new bool[Option_class.HMO];
        private Stopwatch[] stoptimer = new Stopwatch[Option_class.HMO];

        private void OptionForm_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(reload_everyting1);
            timer1.Tick += new EventHandler(reload_everyting2);
            timer1.Tick += new EventHandler(reload_everyting3);
            timer1.Interval = 50;
            timer1.Start();

            for (int i = 0; i < Option_class.HMO; i++)
                stoptimer[i] = new Stopwatch();
        }
        private void on_off_picture1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((Option_class.check_opt[0] == true) && (gif_is_work[0] == false))
            {
                Option_class.check_opt[0] = false;
                stoptimer[0].Reset();
                return;
            }
            if ((Option_class.check_opt[0] == false) && (gif_is_work[0] == false))
            {
                Option_class.check_opt[0] = true;
                stoptimer[0].Reset();
                return;
            }
        }
        private void on_off_picture2_MouseDown(object sender, MouseEventArgs e)
        {
            if ((Option_class.check_opt[1] == true) && (gif_is_work[1] == false))
            {
                Option_class.check_opt[1] = false;
                stoptimer[1].Reset();
                return;
            }
            if ((Option_class.check_opt[1] == false) && (gif_is_work[1] == false))
            {
                Option_class.check_opt[1] = true;
                stoptimer[1].Reset();
                return;
            }
        }
        private void on_off_picture3_MouseDown(object sender, MouseEventArgs e)
        {
            if ((Option_class.check_opt[2] == true) && (gif_is_work[2] == false))
            {
                Option_class.check_opt[2] = false;
                stoptimer[2].Reset();
                return;
            }
            if ((Option_class.check_opt[2] == false) && (gif_is_work[2] == false))
            {
                Option_class.check_opt[2] = true;
                stoptimer[2].Reset();
                return;
            }
        }
        private void reload_everyting1(object sender, EventArgs e)
        {
            stoptimer[0].Start();
            TimeSpan ts = stoptimer[0].Elapsed;
            if (Option_class.check_opt[0] == true)
            {
                if ((ts.TotalMilliseconds <= 1400) && (gif_is_work[0] == false))
                {
                    gif_is_work[0] = true;
                    on_off_picture1.Image = Properties.Resources._2_gif_buttons_off;
                }
                else if (ts.TotalMilliseconds > 1400)
                {
                    on_off_picture1.Image = Properties.Resources._2_buttons_on;
                    gif_is_work[0] = false;
                }
            }
            if (Option_class.check_opt[0] == false)
            {
                if ((ts.TotalMilliseconds <= 1400) && (gif_is_work[0] == false))
                {
                    gif_is_work[0] = true;
                    on_off_picture1.Image = Properties.Resources._2_gif_buttons_on;
                }
                else if (ts.TotalMilliseconds > 1400)
                {
                    on_off_picture1.Image = Properties.Resources._2_buttons_off;
                    gif_is_work[0] = false;
                }
            }
        }
        private void reload_everyting2(object sender, EventArgs e)
        {
            stoptimer[1].Start();
            TimeSpan ts = stoptimer[1].Elapsed;
            if (Option_class.check_opt[1] == true)
            {
                if ((ts.TotalMilliseconds <= 1400) && (gif_is_work[1] == false))
                {
                    gif_is_work[1] = true;
                    on_off_picture2.Image = Properties.Resources._2_gif_buttons_off;
                }
                else if (ts.TotalMilliseconds > 1400)
                {
                    on_off_picture2.Image = Properties.Resources._2_buttons_on;
                    gif_is_work[1] = false;
                }
            }
            if (Option_class.check_opt[1] == false)
            {
                if ((ts.TotalMilliseconds <= 1400) && (gif_is_work[1] == false))
                {
                    gif_is_work[1] = true;
                    on_off_picture2.Image = Properties.Resources._2_gif_buttons_on;
                }
                else if (ts.TotalMilliseconds > 1400)
                {
                    on_off_picture2.Image = Properties.Resources._2_buttons_off;
                    gif_is_work[1] = false;
                }
            }
        }
        private void reload_everyting3(object sender, EventArgs e)
        {
            stoptimer[2].Start();
            TimeSpan ts = stoptimer[2].Elapsed;
            if (Option_class.check_opt[2] == true)
            {
                if ((ts.TotalMilliseconds <= 1400) && (gif_is_work[2] == false))
                {
                    gif_is_work[2] = true;
                    on_off_picture3.Image = Properties.Resources._2_gif_buttons_off;
                }
                else if (ts.TotalMilliseconds > 1400)
                {
                    on_off_picture3.Image = Properties.Resources._2_buttons_on;
                    gif_is_work[2] = false;
                }
            }
            if (Option_class.check_opt[2] == false)
            {
                if ((ts.TotalMilliseconds <= 1400) && (gif_is_work[2] == false))
                {
                    gif_is_work[2] = true;
                    on_off_picture3.Image = Properties.Resources._2_gif_buttons_on;
                }
                else if (ts.TotalMilliseconds > 1400)
                {
                    on_off_picture3.Image = Properties.Resources._2_buttons_off;
                    gif_is_work[2] = false;
                }
            }
        }

        private void OK_check_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
