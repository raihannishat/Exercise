using System;
using System.Collections.Generic;
using System.Text;

namespace Code_3_1
{
    public class Bicycle
    {
        static int numGears = 6;

        int cadence = 0;
        int speed = 0;
        int gear = 1;

        public void changeCadence(int newValue)
        {
            cadence = newValue;
        }

        public void changeGear(int newValue)
        {
            gear = newValue;
        }

        public void speedUp(int increment)
        {
            speed = speed + increment;
        }

        public void applyBreak(int decrement)
        {
            speed = speed - decrement;
        }

        public void printStates()
        {
            Console.WriteLine("cadence: " + cadence + " speed: " + speed + " gear: " + gear);
        }
    }
}
