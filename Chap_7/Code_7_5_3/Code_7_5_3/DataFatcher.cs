using System;
using System.Collections.Generic;
using System.Text;

namespace Code_7_5_3
{
    public class DataFatcher
    {
        public string fetchDataFromUrl(string url)
        {
            checked
            {
                if (url == null)
                {
                    throw new CheckedException("Url not found");
                }
            }

            string data = null;
            return data;
        }
    }
}
