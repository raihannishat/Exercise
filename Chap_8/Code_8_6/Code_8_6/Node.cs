using System;
using System.Collections.Generic;
using System.Text;

namespace Code_8_6
{
    public class Node<Type>
    {
        public Type value;
        public Node<Type> next;

        public Node(Type value)
        {
            this.value = value;
        }

        public Type getValue()
        {
            return value;
        }

        public void setValue(Type value)
        {
            this.value = value;
        }

        public Node<Type> getNext()
        {
            return next;
        }

        public void setNext(Node<Type> next)
        {
            this.next = next;
        }
    }
}
