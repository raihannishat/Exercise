using System;

namespace Code_8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> integers = new SinglyLinkedList<int>();
            integers.addFirst(4);
            integers.addFirst(3);
            integers.addFirst(2);
            integers.addFirst(1);
            integers.print();

            Console.WriteLine("Remove first and last elements..");
            integers.removeFirst();
            integers.removeLast();
            integers.print();

            Console.WriteLine("add element at last ");
            integers.addLast(5);
            integers.addLast(6);
            integers.addLast(7);
            integers.print();

            SinglyLinkedList<string> stringLinkedList = new SinglyLinkedList<string>();
            stringLinkedList.addFirst("abcd");
            stringLinkedList.addFirst("efgh");
            stringLinkedList.addFirst("ijkl");
            stringLinkedList.addFirst("mnop");
            stringLinkedList.addFirst("qrst");
            stringLinkedList.print();
        }
    }
}
