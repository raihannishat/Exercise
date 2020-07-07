using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_3_1
{
    public class Bicycle
    {
        public int cadence { get; set; }
        public int gear { get; set; }
        public int speed { get; set; }

        public void setCaence(int newValue)
        {
            cadence = newValue;
        }

        public void setGear(int newValue)
        {
            gear = newValue;
        }

        public void applyBreak(int decrement)
        {
            speed -= decrement;
        }

        public void speedUp(int increment)
        {
            speed += increment;
        }
    }
}
