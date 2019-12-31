using System;
using System.Collections.Generic;
using System.Text;

namespace Code_5_2_2
{
    public class Matrix
    {
        Random rnd = new Random();

        /* return a random mXn matrix
           with values between 0 and 1
        */

        public int[,] random(int m, int n)
        {
            int[,] c = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = rnd.Next(100);
                }
            }

            return c;
        }

        // return c = a * b
        public int[,] multiply(int[,] a, int[,] b)
        {
            int mA = a.GetLength(0);
            int nA = a.GetLength(1);
            int mB = b.GetLength(0);
            int nB = b.GetLength(1);
            
            if (nA != mB)
            {
                throw new AggregateException("Illegal matrix dimensions");
            }

            int[,] c = new int[mA, nB];
            for (int i = 0; i < mA; i++)
            {
                for (int j = 0; j < nB; j++)
                {
                    for (int k = 0; k < nA; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return c;
        }

        public int[,] add(int[,] a, int[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            int[,] c = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            return c;
        }

        public int[,] subtract(int[,] a, int[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            int[,] c = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] - b[i, j];
                }
            }

            return c;
        }

        public void print(int[,] x)
        {
            for (int row = 0; row < x.GetLength(0); row++)
            {
                for (int col = 0; col < x.GetLength(1); col++)
                {
                    Console.Write("{0}\t", x[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
