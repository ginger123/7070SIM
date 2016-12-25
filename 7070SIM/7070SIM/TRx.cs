using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7070SIM
{
    abstract class TRx : Subsystem
    {
        private bool isRecieving;

        public bool IsRecieving
        {
            get { return IsRecieving; }
        }
        private bool isSending;

        public bool IsSending
        {
            get { return IsSending; }
        }
        private bool isPKPending;

        public bool IsPKPending
        {
            get { return IsPKPending; }
        }

        private Queue<byte[]> RxBuffer;
        private Queue<byte[]> txBuffer;
        private int ticksToSend;
        private int ticksToReceive;
        /// <summary>
        /// this function is called every time the Trx should send something.
        /// </summary>
        public virtual void SendStart()//default implementation. should definitely be overriden
        {
            isSending=true;
            byte[] temp = txBuffer.Dequeue();
            ticksToSend = temp.Length;
            //do something to send packet
        }
        public virtual void SendEnd()//default implementation. should definitely be overriden
        {
            if (ticksToSend != 0) throw new Exception("Tried to finish sending without actually finishing", new InvalidOperationException());
            isSending=false;
        }

        /// <summary>
        /// this funciton is called everytime the Trx should get something from outside
        /// </summary>
        /// <param name="pkt">packet sent</param>
        public virtual void RecieveStart(byte[] pkt)//default implementation. should definitely be overriden
        {
            isRecieving = true;
            ticksToReceive = pkt.Length;
            RxBuffer.Enqueue(pkt);
            
        }
        public virtual void RecieveEnd()//default implementation. should definitely be overriden
        {
            if (ticksToSend != 0) throw new Exception("Tried to finish receiving without actually finishing", new InvalidOperationException());
            isRecieving = false;
        }
        public override void tick()
        {
            //base.tick();
            if (txBuffer.Count > 0 && !isSending) SendStart();
            if (isSending) ticksToSend--;
            if (ticksToSend == 0) SendEnd();

            if (isRecieving) ticksToReceive--;
            if(ticksToReceive==0) RecieveEnd();
        }
    }
}
