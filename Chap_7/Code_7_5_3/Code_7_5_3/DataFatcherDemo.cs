using System;
using System.Collections.Generic;
using System.Text;

namespace Code_7_5_3
{
    public class DataFatcherDemo
    {
        private DataFatcher dataFatcher;

        public DataFatcherDemo(DataFatcher dataFatcher)
        {
            this.dataFatcher = dataFatcher;
        }

        public void fetchData()
        {
            string url = "http://google.com";

            try
            {
                string fetchData = dataFatcher.fetchDataFromUrl(url);
                Console.WriteLine(fetchData);
            }
            catch (CheckedException e)
            {
                Console.WriteLine($"Message:{e.Message}\n Stack Trace:{Environment.StackTrace}");
            }
        }
    }
}
