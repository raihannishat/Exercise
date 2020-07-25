using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Code_8_7_4
{
    public class HashTable<Key, Value>
    {
        private List<Key> keysList = new List<Key>();
        private List<Value> valueList = new List<Value>();
        private List<int> removeList = new List<int>();

        public void add(Key key, Value value)
        {
            keysList.Add(key);
            valueList.Add(value);
        }

        public void remove(int position)
        {
            keysList.RemoveAt(position - 1);
            valueList.RemoveAt(position - 1);
        }

        public void print()
        {
            for (int i = 0; i < keysList.Count; i++)
            {
                Console.WriteLine($"{keysList[i]} : {valueList[i]}");
            }
        }
    }
}
