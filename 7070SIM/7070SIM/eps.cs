using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7070SIM
{
    abstract class eps: Subsystem
    {
        private bool is_Charging;

        public bool Is_Charging
        {
            get { return is_Charging; }
        }

        private double vbatt;

        public double Vbatt
        {
            get { return vbatt; }
        }

        private double drain;

        public double Drain
        {
            get { return drain; }
        }

        private double input_power;

        public double Input_power
        {
            get { return input_power; }
        }


    }
}
