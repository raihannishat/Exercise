using System;
using System.Text;

namespace Code_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // প্রথমে তো একটি কফিকাপ তৈরি করতে হবে তাই নয় কি ?
            CoffeeCup myCup = new CoffeeCup();

            // এখন আমাদের কতগুলো লিকুইড দরকার
            Liquid genericLiquid = new Liquid();
            Coffee coffee = new Coffee();
            Milk milk = new Milk();

            // এখন প্রয়োজন মতো সেগুলো কাপে ঢালি 
            myCup.addLiquid(genericLiquid);
            myCup.addLiquid(coffee);
            myCup.addLiquid(milk);
        }
    }
}
