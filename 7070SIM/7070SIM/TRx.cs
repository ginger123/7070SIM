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
        private byte[] currentTX;
        private byte[] currentRX;
        private int ticksToSend; // amount of ticks it takes to send the current packet
        private int ticksToReceive; // amount of ticks it takes to receive the current packet
        /// <summary>
        /// this function is automatically called every time the Trx should send something. not by the user(this goes to outside world)
        /// </summary>
        public virtual void SendStart()//default implementation. should definitely be overriden
        {
            //dont forget to increase power consupmtion
            isSending = true;
            currentTX = txBuffer.Dequeue();
            ticksToSend = currentTX.Length;
            
        }
        /// <summary>
        /// this is automaticaly called.
        /// </summary>
        public virtual void SendEnd()//default implementation. should definitely be overriden
        {
            if (ticksToSend != 0) throw new Exception("Tried to finish sending without actually finishing", new InvalidOperationException());
            isSending = false;
            //do something to send packet to outside software
        }

        /// <summary>
        /// this funciton is called everytime the Trx should get something from outside(pkt is what you get from outside software)
        /// </summary>
        /// <param name="pkt">packet sent</param>
        public virtual void RecieveStart(byte[] pkt)//default implementation. should definitely be overriden
        {
            isRecieving = true;
            ticksToReceive = pkt.Length;
            currentRX = pkt;

        }
        /// <summary>
        /// this is automatically called when you finished receiving. this is done to simulate the time it takes for the packet to be sent
        /// </summary>
        public virtual void RecieveEnd()//default implementation. should definitely be overriden
        {
            if (ticksToSend != 0) throw new Exception("Tried to finish receiving without actually finishing", new InvalidOperationException());
            RxBuffer.Enqueue(currentRX);
            isRecieving = false;
        }
        public override void tick()
        {
            //base.tick();
            if (txBuffer.Count > 0 && !isSending) SendStart();
            if (isSending) ticksToSend--;
            if (ticksToSend == 0) SendEnd();

            if (isRecieving) ticksToReceive--;
            if (ticksToReceive == 0) RecieveEnd();
        }
    }
}
