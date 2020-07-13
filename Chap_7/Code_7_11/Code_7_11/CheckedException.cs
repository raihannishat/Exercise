using System;
using System.Collections.Generic;
using System.Text;

namespace Code_7_11
{
    public class CheckedException : Exception
    {
        public CheckedException(string message) : base(message)
        {

        }
    }
}
