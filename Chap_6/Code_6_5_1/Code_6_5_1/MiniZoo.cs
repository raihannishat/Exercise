using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_5_1
{
    public class MiniZoo
    {
        private Animal[] animals;

        public MiniZoo(Animal[] animals)
        {
            this.animals = animals;
        }

        public void putThemOnSleep()
        {
            Array.ForEach(animals, x => x.sleep());
        }
    }
}
