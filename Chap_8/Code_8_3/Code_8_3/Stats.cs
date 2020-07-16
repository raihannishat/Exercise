using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Code_8_3
{
    public class Stats<T>
    {
        private T[] nums;

        public Stats(T[] nums)
        {
            this.nums = nums;
        }

        // return type double in all cases.
        public double average()
        {
            double sum = 0.0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += Convert.ToDouble(nums[i]);
            }

            return sum / nums.Length;
        }
    }
}
