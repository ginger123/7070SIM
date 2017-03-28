using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Concurrent;
using System.IO;

namespace _7070SIM
{
    public partial class Corrent_Stat : Form
    {
        public Corrent_Stat()
        {
            InitializeComponent();
        }
        public static SerialPort sp;
        public static ConcurrentQueue<byte[]> msgQueue = new ConcurrentQueue<byte[]>();
        public static Timer timekeeper = new Timer();
        public static Timer ticker = new Timer();
        public static string testing_reciving_text;
        public string data_in_logger = testing_reciving_text;
        public static string suffix = "";

        public static bool logger_is_open = false, options_is_open = false;


        public struct settings
        {
            public string serialPort;
            public int baudRate;
        }
        public static settings userSetting = new settings();

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!ticker.Enabled)
            {
                userSetting.serialPort = "COM2";//TODO: add this to startup options
                userSetting.baudRate = 9600;

                //
                sp = new SerialPort(userSetting.serialPort, userSetting.baudRate);
                sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                sp.Open();
                timekeeper.Start();
                MessageBox.Show("opened");

                
                ticker.Start();
            }

        }


        private void stopButton_Click(object sender, EventArgs e)
        {
            if (ticker.Enabled)
            {
                timekeeper.Stop();
                ticker.Stop();
                
                MessageBox.Show("closed");
                sp.Close();
                sp = null;
            }
            else
                MessageBox.Show("Simulation not Running! push start");

        }

        public static void fulltick(object sender, EventArgs e)
        {

            byte[] arrToSend = Encoding.ASCII.GetBytes("HELLO");
            sp.Write(arrToSend, 0, arrToSend.Length);

        }
        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            int x = 0;
            if (sp.ReadByte() != 0xC0) return;
            string tempmsg = "";
            while (true)
            {

                x = sp.ReadByte();
                if (x == 0xC0) break;
                if (x == 0xDB)
                {
                    x = sp.ReadByte();
                    if (x == 0xDC) x = 0xC0;//frame end
                    if (x == 0xDD) x = 0xDB;//frame escape 
                }
                tempmsg += (char)x;
                System.Threading.Thread.Sleep(5);
            }
            //tempmsg is now without KISS
            byte[] ret = new byte[tempmsg.Length];
            for (int i = 0; i < tempmsg.Length; i++)
            {
                ret[i] = (byte)tempmsg[i];
            }
            msgQueue.Enqueue(ret);
            MessageBox.Show(BitConverter.ToString(ret).Replace('-',' '));

        }


        private Timer timer1;
        private void Form1_Load(object sender, EventArgs e)
        {

            //init simulation timer
            ticker.Interval = 20000;
            ticker.Tick += new EventHandler(fulltick);
            //something else
            timekeeper.Interval = 1000;
            timekeeper.Tick += new EventHandler(handleCommand);
            if (true)
            {
                timer1 = new Timer();
                timer1.Tick += new EventHandler(refrash_text);
                timer1.Interval = 20;
                timer1.Start();

                tabPage1.ScrollControlIntoView(tabPage1);
            }
            loggerTextBox_on_correntStat.ScrollBars = ScrollBars.Vertical;
            Form TEXT_test_open = new TEXT_test();
            TEXT_test_open.Show();

            //"A first chance exception of type 'System.ArgumentException' occurred in mscorlib.dll" only happend once when loading without log file
            suffix = File.ReadAllText(Config.path_in_textbox) + Environment.NewLine + "---@new_log@---" + Environment.NewLine;
        }
        private void refrash_text(object sender, EventArgs e)
        {
            data_in_logger = testing_reciving_text;
            loggerTextBox_on_correntStat.Text = suffix + data_in_logger;
            if (Option.check_opt[0] == true)
            {
                DateTime localDate = DateTime.Now;
                string time_date, minit, hours, secends;

                if (localDate.Second < 10)
                    secends = "0" + localDate.Second;
                else
                    secends = "" + localDate.Second;

                if (localDate.Minute < 10)
                    minit = "0" + localDate.Minute;
                else
                    minit = "" + localDate.Minute;

                if (localDate.Hour < 10)
                    hours = "0" + localDate.Hour;
                else
                    hours = "" + localDate.Hour;

                time_date = "<" + hours + ":" + minit + ":" + secends + ">";

                this.Text = "Corrent Stat - " + time_date;
            }
            else
            {
                this.Text = "Corrent Stat";
            }
            double battary = 0;
            int tester;
            if (Int32.TryParse(textBox1.Text, out tester))
                if(int.Parse(textBox1.Text) <= 100 && int.Parse(textBox1.Text) >= 0)
                {
                    battary = int.Parse(textBox1.Text);
                    progressBar1.Value = Convert.ToInt32(battary);
                    label3.Text = battary + "%";
                }
            if (battary > 50)
            {
                isCharging.BackColor = Color.Red;
                pictureBox1.Image = Properties.Resources.red;
            }
            else
            {
                isCharging.BackColor = Color.Lime;
                pictureBox1.Image = Properties.Resources.green;
            }
        }
        public static void handleCommand(object sender, EventArgs e)
        {
            MessageBox.Show("entering function");//TODO: debug
            if (msgQueue.IsEmpty) return;
            byte[] rawCommand;
            msgQueue.TryDequeue(out rawCommand);
            //first byte is system adress
            //second byte is command adress
            //after that it's only params
            byte[] commandParameter = new byte[rawCommand.Length - 2];
            for (int i = 0; i < rawCommand.Length - 2; i++)
            {
                commandParameter[i] = rawCommand[i + 2];
            }
            /*            byte[] rawResponse= addressToSybsystem(rawCommand[0]).doComm(rawCommand[1],commandParameter);
                        if (rawResponse != null)
                        {
                            byte[] response = new byte[rawResponse.Length + 1];
                            response[0] = rawCommand[0];//subsytem originating from
                            for (int i = 0; i < rawResponse.Length; i++)//load answer to response
                            {
                                response[i + 1] = rawResponse[i];
                            }
                            sp.Write(response, 0, response.Length);
                        }*/
        }/*
        public static Subsystem addressToSybsystem(byte addr)
        {
            return null;
        }*/

        private void loggerTextBox_on_correntStat_TextChanged(object sender, EventArgs e)
        {
            data_in_logger = loggerTextBox_on_correntStat.Text;
            loggerTextBox_on_correntStat.SelectionStart = loggerTextBox_on_correntStat.Text.Length;
            loggerTextBox_on_correntStat.ScrollToCaret();
            loggerTextBox_on_correntStat.Refresh();
        }

        private void loggerTextBox_on_correntStat_DoubleClick(object sender, EventArgs e)
        {
            Form Logger_window = new Logger_window();
            if (logger_is_open == false)
            {
                logger_is_open = true;
                Logger_window.Show();
            }
        }

        private void Option_button_Click(object sender, EventArgs e)
        {
            Form OptionForm = new OptionForm();
            if (options_is_open == false)
            {
                options_is_open = true;
                OptionForm.Show();
            }
        }

        public void log(string subsystem, string text)
        {
            string toadd = "";
            DateTime localDate = DateTime.Now;
            string time_date, minit, hours, secends;

            if (localDate.Second < 10)
                secends = "0" + localDate.Second;
            else
                secends = localDate.Second.ToString();

            if (localDate.Minute < 10)
                minit = "0" + localDate.Minute;
            else
                minit = localDate.Minute.ToString();

            if (localDate.Hour < 10)
                hours = "0" + localDate.Hour;
            else
                hours = localDate.Hour.ToString();

            time_date = "<" + hours + ":" + minit + ":" + secends + ">";
            toadd = time_date;
            toadd += subsystem + " : " + text;


        }
        
    }
}
