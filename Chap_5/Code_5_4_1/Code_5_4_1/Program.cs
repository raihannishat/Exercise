using System;

namespace Code_5_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            int[] copyTo = new int[10];

            Array.Copy(myArray, copyTo, 10);

            for (int i = 0; i < myArray.Length; i++)
            {
                copyTo[i] = myArray[i];
            }
        }
    }
}
