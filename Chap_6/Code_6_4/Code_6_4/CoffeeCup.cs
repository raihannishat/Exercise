using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_4
{
    public class CoffeeCup
    {
        private Liquid innerLiquid;

        public void addLiquid(Liquid liquid)
        {
            innerLiquid = liquid;
            innerLiquid.swirl(false);
        }
    }
}
