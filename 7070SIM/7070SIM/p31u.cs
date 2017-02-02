using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7070SIM
{
    class p31u :eps
    {
        public override void tick()
        {
            is_Charging = (input_power > drain);
        }
        bool pin1_3_3v;
        bool pin2_3_3v;
        bool pin3_3_3v;
        bool pin1_5v;
        bool pin2_5v;
        bool pin3_5v;

        public byte[] comm9_setOutput(byte[] arr)
        {
            pin3_3_3v = ((arr[0] & (1 << 2)) != 0);
            pin2_3_3v = ((arr[0] & (1 << 3)) != 0);
            pin1_3_3v = ((arr[0] & (1 << 4)) != 0);

            pin3_5v = ((arr[0] & (1 << 5)) != 0);
            pin2_5v = ((arr[0] & (1 << 6)) != 0);
            pin1_5v = ((arr[0] & (1 << 7)) != 0);

            return null;
        }
    }
}
