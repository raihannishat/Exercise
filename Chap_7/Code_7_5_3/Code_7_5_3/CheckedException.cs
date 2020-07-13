using System;
using System.Collections.Generic;
using System.Text;

namespace Code_7_5_3
{
    public class CheckedException : Exception
    {
        public CheckedException(string message) : base(message)
        {
            
        }
    }
}
