using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7070SIM
{
    class QBAntS : ants
    {
        const int AntNum = 4;
        private bool IsArmed;
        private bool[] IsDeploy = new bool[AntNum];//default is false, already deployed
        private bool[] IsDeploying = new bool[AntNum]; //is currently deploying
        private bool[] SwitchActivated = new bool[AntNum];
        private byte DeployTime;
        private bool AutoAntdeploying;
        private byte[] SystemTemp;
        private bool IsOverride;
        private bool IndependentBurn;
        private byte[] CountDeploy = new byte[AntNum];
        private byte[] SumDepTime = new byte[AntNum];

        public QBAntS()
        {
            commArr = new Func<byte[], byte[]>[196];
            commArr[170] = new Func<byte[], byte[]>(comm_10101010_reset);
            commArr[173] = new Func<byte[], byte[]>(comm_10101101_ArmAnts);
            commArr[172] = new Func<byte[], byte[]>(comm_10101100_DisarmAnts);
            commArr[161] = new Func<byte[], byte[]>(comm_10100001_deployAnt1);
            commArr[162] = new Func<byte[], byte[]>(comm_10100010_deployAnt2);
            commArr[163] = new Func<byte[], byte[]>(comm_10100011_deployAnt3);
            commArr[164] = new Func<byte[], byte[]>(comm_10100100_deployAnt4);
            commArr[165] = new Func<byte[], byte[]>(comm_10100101_AutoAntdeploy);
            commArr[186] = new Func<byte[], byte[]>(comm_10111010_deployAnt1_Override);
            commArr[187] = new Func<byte[], byte[]>(comm_10111011_deployAnt2_Override);
            commArr[188] = new Func<byte[], byte[]>(comm_10111100_deployAnt3_Override);
            commArr[189] = new Func<byte[], byte[]>(comm_10111101_deployAnt4_Override);
            commArr[169] = new Func<byte[], byte[]>(comm_10101001_CancelDep);
            commArr[192] = new Func<byte[], byte[]>(comm_11000000_MeasureAntSysTemp);
            commArr[195] = new Func<byte[], byte[]>(comm_11000011_ReportDeployStatus);
            commArr[176] = new Func<byte[], byte[]>(comm_10110000_Ant1DepCount);
            commArr[177] = new Func<byte[], byte[]>(comm_10110001_Ant2DepCount);
            commArr[178] = new Func<byte[], byte[]>(comm_10110010_Ant3DepCount);
            commArr[179] = new Func<byte[], byte[]>(comm_10110011_Ant4DepCount);
            commArr[180] = new Func<byte[], byte[]>(comm_10110100_Ant1ActivTime);
            commArr[181] = new Func<byte[], byte[]>(comm_10110101_Ant2ActivTime);
            commArr[182] = new Func<byte[], byte[]>(comm_10110110_Ant3ActivTime);
            commArr[183] = new Func<byte[], byte[]>(comm_10110111_Ant4ActivTime);
        }
        

        public byte[] comm_10101010_reset(byte[] arr)//Performs a reset of the microcontroller
        {
            for (int i = 0; i < AntNum; i++)
            {
                SumDepTime[i] = 0;
            }
            return null;
        }
        public byte[] comm_10101101_ArmAnts(byte[] arr)// Arms the ant, the system needs to be armed to deploy ants
        {
            IsArmed = true;
            return null;
        }
        public byte[] comm_10101100_DisarmAnts(byte[] arr)// will deactivate any active antenna deployment system
        {
            IsArmed = false;
            return null;
        }
        public byte[] comm_10100001_deployAnt1(byte[] arr) //attempt to deploy antenna 1
        {
            if (IsArmed && !IsDeploy[0] && AreAntsDeploying() && !AutoAntdeploying)
            {
                CountDeploy[0]++;
                DeployStart(0);
            }
            return null;
        }
        public byte[] comm_10100010_deployAnt2(byte[] arr) //attempt to deploy antenna 2
        {
            if (IsArmed && !IsDeploy[1] && AreAntsDeploying() && !AutoAntdeploying)
            {
                CountDeploy[1]++;
                DeployStart(1);
            }
            return null;
        }
        public byte[] comm_10100011_deployAnt3(byte[] arr) //attempt to deploy antenna 3
        {
            if (IsArmed && !IsDeploy[2] && AreAntsDeploying() && !AutoAntdeploying)
            {
                CountDeploy[2]++;
                DeployStart(2);
            }
            return null;
        }
        public byte[] comm_10100100_deployAnt4(byte[] arr) //attempt to deploy antenna 4
        {
            if (IsArmed && !IsDeploy[3] && AreAntsDeploying() && !AutoAntdeploying)
            {
                CountDeploy[3]++;
                DeployStart(3);
            }
            return null;
        }
        public void DeployStart(int ant)
        {
            IsDeploying[ant] = true;
            SumDepTime[ant] += DeployTime;
            DeployEnd();
        }
        public void DeployEnd()
        {
            if (DeployTime != 0) throw new Exception("Tried to finish deploying without actually finishing", new InvalidOperationException());

            int ant = 0;
            for (int i = 0; i < 4; i++)
            {
                if (IsDeploying[i])
                {
                    IsDeploying[i] = false;
                    ant = i;
                    break;
                }
            }
            IsDeploy[ant] = true;
        }
        private bool AreAntsDeploying()//return false if deploying
        {
            for (int i = 0; i < 4; i++)
            {
                if (IsDeploying[i]) return false;
            }
            return true;
        }
        public override void tick(byte[] arr)
        {
            if (DeployTime > 0)
                DeployTime--;
            if (DeployTime == 0) DeployEnd();
        }
        //deployment switcher = whether the antenna is deployed or not deployed
        public byte[] comm_10100101_AutoAntdeploy(byte[] arr)//Attempt to sequentially deploy all the antennas
        {
            if (IsArmed && AreAntsDeploying() && !AutoAntdeploying)
            {
                AutoAntdeploying = true;
                comm_10100001_deployAnt1();
                tick();
                comm_10100010_deployAnt2();
                tick();
                comm_10100011_deployAnt3();
                tick();
                comm_10100100_deployAnt4();
                CountDeploy[0]++;
                CountDeploy[1]++;
                CountDeploy[2]++;
                CountDeploy[3]++;
            }
            return null;
        }
        public byte[] comm_10111010_deployAnt1_Override(byte[] arr)//Deploy antenna 1 with override
        {
            if (IsArmed && AreAntsDeploying() && !AutoAntdeploying)
            {
                IsOverride = true;
                DeployStart(0);
            }
            return null;
        }
        public byte[] comm_10111011_deployAnt2_Override(byte[] arr)//Deploy antenna 2 with override
        {
            if (IsArmed && AreAntsDeploying() && !AutoAntdeploying)
            {
                IsOverride = true;
                DeployStart(1);
            }
            return null;
        }
        public byte[] comm_10111100_deployAnt3_Override(byte[] arr)//Deploy antenna 3 with override
        {
            if (IsArmed && AreAntsDeploying() && !AutoAntdeploying)
            {
                IsOverride = true;
                DeployStart(2);
            }
            return null;
        }
        public byte[] comm_10111101_deployAnt4_Override(byte[] arr)//Deploy antenna 4 with override
        {
            if (IsArmed && AreAntsDeploying() && !AutoAntdeploying)
            {
                IsOverride = true;
                DeployStart(3);
            }
            return null;
        }
        public byte[] comm_10101001_CancelDep(byte[] arr)//panica!!!! 6.2.13
        {
            return null;
        }
        public byte[] comm_11000000_MeasureAntSysTemp(byte[] arr)//Measure the tempeture reported by the tempeture sensor 
        {
            return SystemTemp;//check Annex C for convention table
        }
        public byte[] comm_11000011_ReportDeployStatus(byte[] arr)
        {
            byte[] FullStatus = new byte[16];
            FullStatus[0] = Convert.ToByte(SwitchActivated[0]);
            FullStatus[1] = Convert.ToByte(SwitchActivated[2]);

            FullStatus[2] = Convert.ToByte(IsDeploy[0]);
            FullStatus[3] = Convert.ToByte(IsDeploy[2]);

            FullStatus[4] = Convert.ToByte(IsDeploying[0]);
            FullStatus[5] = Convert.ToByte(IsDeploying[2]);

            FullStatus[6] = 0;
            FullStatus[7] = Convert.ToByte(IndependentBurn);//The antenna system independent burn is currently active.

            FullStatus[8] = Convert.ToByte(SwitchActivated[1]);
            FullStatus[9] = Convert.ToByte(SwitchActivated[3]);

            FullStatus[10] = Convert.ToByte(IsDeploy[1]);
            FullStatus[11] = Convert.ToByte(IsDeploy[3]);

            FullStatus[12] = Convert.ToByte(IsDeploying[1]);
            FullStatus[13] = Convert.ToByte(IsDeploying[3]);

            FullStatus[14] = Convert.ToByte(IsOverride);
            FullStatus[15] = Convert.ToByte(IsArmed);
            return FullStatus;
        }
        public byte[] comm_10110000_Ant1DepCount(byte[] arr)
        {
            byte[] Temp = new byte[1];
            Temp[0] = CountDeploy[0];
            return Temp;
        }
        public byte[] comm_10110001_Ant2DepCount(byte[] arr)
        {
            byte[] Temp = new byte[1];
            Temp[0] = CountDeploy[1];
            return Temp;
        }
        public byte[] comm_10110010_Ant3DepCount(byte[] arr)
        {
            byte[] Temp = new byte[1];
            Temp[0] = CountDeploy[2];
            return Temp;
        }
        public byte[] comm_10110011_Ant4DepCount(byte[] arr)
        {
            byte[] Temp = new byte[1];
            Temp[0] = CountDeploy[3];
            return Temp;
        }
        public byte[] comm_10110100_Ant1ActivTime(byte[] arr)
        {
            byte[] Temp = new byte[1];
            Temp[0] = SumDepTime[0];
            return Temp;
        }
        public byte[] comm_10110101_Ant2ActivTime(byte[] arr)
        {
            byte[] Temp = new byte[1];
            Temp[0] = SumDepTime[1];
            return Temp;
        }
        public byte[] comm_10110110_Ant3ActivTime(byte[] arr)
        {
            byte[] Temp = new byte[1];
            Temp[0] = SumDepTime[2];
            return Temp;
        }
        public byte[] comm_10110111_Ant4ActivTime(byte[] arr)
        {
            byte[] Temp = new byte[1];
            Temp[0] = SumDepTime[3];
            return Temp;
        }
    }
}