﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Concurrent;

namespace _7070SIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static SerialPort sp;
        public static ConcurrentQueue<byte[]> msgQueue = new ConcurrentQueue<byte[]>();
        public static Timer timekeeper = new Timer();
        public struct settings
        {
            public string serialPort;
            public int baudRate;
        }
        public static settings userSetting = new settings();
        private void startButton_Click(object sender, EventArgs e)
        {
            userSetting.serialPort = "COM1";
            userSetting.baudRate = 9600;

            //
            sp = new SerialPort(userSetting.serialPort, userSetting.baudRate);
            sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            sp.Open();
            sp.Write("hi");
            MessageBox.Show("opened");
        }


        public static void fulltick()
        {

        }
        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            int x = 0;
            if (sp.ReadChar() != 0xC0) return;
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
            }
            //tempmsg is now without KISS
            byte[] ret = new byte[tempmsg.Length];
            for (int i = 0; i < tempmsg.Length; i++)
            {
                ret[i] = (byte)tempmsg[i];
            }
            msgQueue.Enqueue(ret);

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            sp.Close();
            MessageBox.Show("closed");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timekeeper.Interval = 1000;
            timekeeper.Tick += new EventHandler(handleCommand);
        }
        public static void handleCommand(object sender, EventArgs e)
        {
            if (!msgQueue.IsEmpty) return;
            byte[] rawCommand;
            msgQueue.TryDequeue(out rawCommand);
            //first byte is system adress
            //second byte is command adress
            //after that it's only params
            byte[] commandParameter= new byte[rawCommand.Length-2];
            for(int i=0;i<rawCommand.Length-2;i++)
            {
                commandParameter[i]=rawCommand[i+2];
            }
            byte[] rawResponse= addressToSybsystem(rawCommand[0]).doComm(rawCommand[1],commandParameter);
            if (rawResponse != null)
            {
                byte[] response = new byte[rawResponse.Length + 1];
                response[0] = rawCommand[0];//subsytem originating from
                for (int i = 0; i < rawResponse.Length; i++)//load answer to response
                {
                    response[i + 1] = rawResponse[i];
                }
                sp.Write(response, 0, response.Length);
            }
        }
        public static Subsystem addressToSybsystem(byte addr)
        {
            return null;
        }

    }
}
