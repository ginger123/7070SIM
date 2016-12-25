using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7070SIM
{
    abstract class ants: Subsystem
    {
        private bool isDeployed;

        public bool IsDeployed
        {
            get { return isDeployed; }
        }

        public void deploy()
        {
            isDeployed = true;
        }
    }
}
