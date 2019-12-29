using System;
using System.Collections.Generic;
using System.Text;

namespace Code_4_4
{
    public class Return
    {
        public double getPayAmount()
        {
            if (isDead())
            {
                return calculateDeadAmount();
            }
            if (isSeparated())
            {
                return calculateSeparatedAmount();
            }
            if (isRetired())
            {
                return calculateRetiredAmount();
            }
            return calculateNormalPayAmount();
        }

        public void displyText(string text)
        {
            if (text == null)
            {
                return;
            }

            Console.WriteLine(text);
        }
    }
}
