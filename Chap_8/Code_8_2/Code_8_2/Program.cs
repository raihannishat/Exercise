using System;

namespace Code_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Container<int> container = new Container<int>();
            container.addItem(1);
            container.addItem(2);
            container.printAll();

            Container<string> stringContainer = new Container<string>();
            Container<object> objectCotainer = stringContainer;
            objectCotainer.addItem(new object());
            string item = stringContainer.getItem(0);

            string str = "456";
            object obj = str;

            object myObj = new object();
            string s = myObj;
        }
    }
}
