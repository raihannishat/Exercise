using System;

namespace Code_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> iObj;
            iObj = new Generic<int>(88);
            iObj.showType();
            int v = iObj.getObj();
            Console.WriteLine($"Value: {v}");

            Generic<string> strObj = new Generic<string>("This is a Generics Test");
            strObj.showType();
            string str = strObj.getObj();
            Console.WriteLine($"Value: {str}");
            
            MyTuple<string, string> tuple = new MyTuple<string, string>("Hello", "World");
            tuple.showType();

            MyTuple<string, int> person = new MyTuple<string, int>("Rahim", 45);
            person.showType();

            MyTuple<string, MyTuple<int, int>> tupleInsideTuple;
            tupleInsideTuple = new MyTuple<string, MyTuple<int, int>>("Tuple", new MyTuple<int, int>(45, 89));
        }
    }
}
