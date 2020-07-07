using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_3_1
{
    public class MountainBike : Bicycle
    {
        public int seatHeight { get; set; }

        public void seatHeihgt(int newValue)
        {
            seatHeight = newValue;
        }
    }
}
