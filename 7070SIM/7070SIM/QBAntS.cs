﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7070SIM
{
    class QBAntS
    {

        private bool IsArmed;
        private bool[] IsDeploy = new bool[4];//default is false, already deployed
        private bool[] IsDeploying = new bool[4]; //is currently deploying
        private byte DeployTime;
        private bool AutoAntdeploying;
        
        public byte[] comm_10101010_reset()//Performs a reset of the microcontroller
        {
            return null;
        }
        public byte[] comm_10101101_ArmAnts()// Arms the ant, the system needs to be armed to deploy ants
        {
            IsArmed = true;
            return null;
        }
        public byte[] comm_10101100_DisarmAnts()// will deactivate any active antenna deployment system
        {
            IsArmed = false;
            return null;
        }
        public byte[] comm_10100001_deployAnt1() //attempt to deploy antenna 1
        {
            if (IsArmed && !IsDeploy[0] && AreAntsDeploying() && !AutoAntdeploying)
            {
                DeployStart(0);
            }
            return null;
        }
        public byte[] comm_10100010_deployAnt2() //attempt to deploy antenna 2
        {
            if (IsArmed && !IsDeploy[1] && AreAntsDeploying() && !AutoAntdeploying)
            {
                DeployStart(1);
            }
            return null;
        }
        public byte[] comm_10100011_deployAnt3() //attempt to deploy antenna 3
        {
            if (IsArmed && !IsDeploy[2] && AreAntsDeploying() && !AutoAntdeploying)
            {
                DeployStart(2);
            }
            return null;
        }
        public byte[] comm_10100100_deployAnt4() //attempt to deploy antenna 4
        {
            if (IsArmed && !IsDeploy[3] && AreAntsDeploying() && !AutoAntdeploying)
            {
                DeployStart(3);
            }
            return null;
        }
        public void DeployStart(int ant)
        {
            IsDeploying[ant] = true;
        }
        public void DeployEnd()
        {
            if (DeployTime != 0) throw new Exception("Tried to finish deploying without actually finishing", new InvalidOperationException());
            
            int ant=0;
            for (int i=0;i<4;i++)
            {
                if (IsDeploying[i])
                {
                    IsDeploying[i] = false;
                    ant=i;
                    break;
                }
            }
            IsDeploy[ant] = true;
        }
        private bool AreAntsDeploying()
        {
            for (int i = 0; i < 4; i++)
            {
                if (IsDeploying[i]) return false;
            }
            return true;
        }
        public override void tick()
        {
            if (DeployTime > 0)
                DeployTime--; 
            if (DeployTime == 0) DeployEnd();
        }
        //**this is wait, a func to wait the deploy time before the next deploy
        public override void wait()
        {
            byte WaitForDeploy = DeployTime;
            while (WaitForDeploy!=0)
                WaitForDeploy--;
        }
        public byte[] comm_10100101_AutoAntdeploy()//Start automated sequential antenna deployment
        {
            
            if (IsArmed && AreAntsDeploying())
            {
                AutoAntdeploying = true;
                comm_10100001_deployAnt1();
                wait();
                comm_10100010_deployAnt2();
                wait();
                comm_10100011_deployAnt3();
                wait();
                comm_10100100_deployAnt4();
            }
            AutoAntdeploying = false;
            return null;
        }
        //check it!!
        //deployment switcher = whether the antenna is deployed or not deployed
        public byte[] comm_10111010_deployAnt1_Override()//Deploy antenna 1 with override
        {
            if (IsArmed && AreAntsDeploying() && !AutoAntdeploying)
            {
                DeployStart(0);
            }
            return null;
        }
        public byte[] comm_10111011_deployAnt2_Override()//Deploy antenna 2 with override
        {
            if (IsArmed && AreAntsDeploying() && !AutoAntdeploying)
            {
                DeployStart(1);
            }
            return null;
        }
        public byte[] comm_10111100_deployAnt3_Override()//Deploy antenna 3 with override
        {
            if (IsArmed && AreAntsDeploying() && !AutoAntdeploying)
            {
                DeployStart(2);
            }
            return null;
        }
        public byte[] comm_10111101_deployAnt4_Override()//Deploy antenna 4 with override
        {
            if (IsArmed && AreAntsDeploying() && !AutoAntdeploying)
            {
                DeployStart(3);
            }
            return null;
        }

    }
}