using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7070SIM
{
    class QBAntS
    {

        private bool IsArmed;
        private bool IsDeploy = false;//antenna deployment system is currently active
        private byte DeployTime;
        public static void reset()//Performs a reset of the microcontroller
        {
            //command code 10101010
        }
        public void ArmAnts()// Arms the ant, the system needs to be armed to deploy ants
        {
            //command code 10101101
            IsArmed = true;
        }
        public void DisarmAtns()// will deactivate any active antenna deployment system
        {
            //command code 10101100
            IsArmed = false;
        }
        public void deployAnt1() //attempt to deploy antenna 1
        {
            // command code 10100001
            if (IsArmed && !IsDeploy && DeployTime>0)
            {
                DeployStart();
                DeployTime--;
            }
            if (DeployTime == 0)
            {
                DeployEnd();
            }
        }
        public void deployAnt2() //attempt to deploy antenna 2
        {
            if (IsArmed && !IsDeploy && DeployTime > 0)
            {
                DeployStart();
                DeployTime--;
            }
            if (DeployTime == 0)
            {
                DeployEnd();
            }
        }
        public void deployAnt3() //attempt to deploy antenna 3
        {
            if (IsArmed && !IsDeploy && DeployTime > 0)
            {
                DeployStart();
                DeployTime--;
            }
            if (DeployTime == 0)
            {
                DeployEnd();
            }
        }
        public void deployAnt4() //attempt to deploy antenna 4
        {
            if (IsArmed && !IsDeploy && DeployTime > 0)
            {
                DeployStart();
                DeployTime--;
            }
            if (DeployTime == 0)
            {
                DeployEnd();
            }
        }
        public void DeployStart()
        {
            IsDeploy = true;
        }
        public void DeployEnd()
        {
            if (DeployTime != 0) throw new Exception("Tried to finish deploying without actually finishing", new InvalidOperationException());
            IsDeploy = false;
        }
    }
}
