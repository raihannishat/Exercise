using System;

namespace Code_6_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            Dog dog2 = new DeshiDog();
            Dog dog3 = new BideshiDog();

            dog1.getType();
            dog2.getType();
            dog3.getType();

            if (dog3 is BideshiDog) 
            {
                ((BideshiDog)dog3).getName();
            }
        }
    }
}
