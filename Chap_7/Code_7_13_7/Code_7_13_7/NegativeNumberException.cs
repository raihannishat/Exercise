using System;
using System.Collections.Generic;
using System.Text;

namespace Code_7_13_7
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message)
        {

        }
    }
}
