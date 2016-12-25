using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7070SIM
{
    abstract class Subsystem
    {
        private double power;//power in watt
        Func<byte[], byte[]>[] commArr;
        public double Power
        {
            get { return power; }
        }
        private bool isOn;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }
        private int tickTime;//time between ticks in millieseconds

        public int TickTime
        {
            get { return tickTime; }
        }
        public virtual void tick()
        {
            //this is empty. for now:)
        }
        public byte[] doComm(int comm,byte[] input)
        {
            return commArr[comm](input);
        }

    }
}
