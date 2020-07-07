using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_3_1
{
    public sealed class Password
    {
        private char[] hash { get; set; }

        public Password(char[] hash)
        {
            this.hash = hash;
        }

        // some useful method
    }
}
