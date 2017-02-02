using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7070SIM
{
    abstract class Subsystem
    {
        protected double power;//power in watt
        Func<byte[], byte[]>[] commArr;
        public double Power
        {
            get { return power; }
        }
        protected bool isOn;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }
        protected int tickTime;//time between ticks in millieseconds

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
