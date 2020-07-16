using System;
using System.Collections.Generic;
using System.Text;

namespace Code_8_5
{
    public class Util
    {
        // Generic static method
        public static bool compare<K, V>(Dictionary<K, V> p1, Dictionary<K, V> p2)
        {
            return p1.Keys.Equals(p2.Keys) && p1.Values.Equals(p2.Values);
        }
    }
}
