using System;
using System.Collections.Generic;
using System.Text;

namespace Code_8_7_3
{
    public class Singleton<T>
    {
        private static T instance = null;

        public static T getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton<T>();
            }

            return instance;
        }
    }
}
