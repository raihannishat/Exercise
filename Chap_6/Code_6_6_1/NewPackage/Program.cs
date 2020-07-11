using System;

namespace NewPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld helloWorld = new HelloWorld();
            string version = helloWorld.version;
            int randomInt = helloWorld.getRandomInt();
        }
    }
}
