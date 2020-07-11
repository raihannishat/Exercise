using System;

namespace Code_6_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Tiger(4);
            animals[1] = new Lion(4);
            animals[2] = new Deer(4);

            MiniZoo miniZoo = new MiniZoo(animals);
            miniZoo.putThemOnSleep();
        }
    }
}
