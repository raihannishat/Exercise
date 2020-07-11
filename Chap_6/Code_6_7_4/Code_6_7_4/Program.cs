using System;

namespace Code_6_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Horse();
            UseAnimal useAnimal = new UseAnimal();
            useAnimal.doSomething(animal);
        }
    }
}
