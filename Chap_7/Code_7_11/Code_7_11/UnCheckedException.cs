using System;
using System.Collections.Generic;
using System.Text;

namespace Code_7_11
{
    public class UnCheckedException : Exception
    {
        public UnCheckedException(string message) : base(message)
        {

        }
    }
}
