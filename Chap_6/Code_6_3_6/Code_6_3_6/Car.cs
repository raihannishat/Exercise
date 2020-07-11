using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_3_6
{
    public class Car : Automobile
    {
        private static readonly int TOTAL_DOOR = 4;
        private static readonly int TOTAL_WHEEL = 4;

        private Engine engine;
        private Door[] doors;
        private Wheel[] wheels;

        public Car()
        {
            engine = new Engine();
            doors = new Door[TOTAL_DOOR];
            wheels = new Wheel[TOTAL_WHEEL];
        }

        public void go()
        {

        }

        // rest of methods
    }
}
