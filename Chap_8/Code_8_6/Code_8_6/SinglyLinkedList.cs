using System;
using System.Collections.Generic;
using System.Text;

namespace Code_8_6
{
    public class SinglyLinkedList<Type>
    {
        private long _size;
        private Node<Type> _head;
        private Node<Type> _tail;

        public void addFirst(Type value)
        {
            addFirst(new Node<Type>(value));
        }

        public void addLast(Type value)
        {
            addLast(new Node<Type>(value));
        }

        public void addLast(Node<Type> node)
        {
            if (_size == 0)
            {
                _head = node;
            }
            else
            {
                _tail.setNext(node);
            }

            _tail = node;
            _size++;
        }

        public void addFirst(Node<Type> node)
        {
            Node<Type> temp = _head;
            _head = node;
            _head.setNext(temp);

            _size++;

            if (_size == 1)
            {
                _tail = _head;
            }
        }

        public Node<Type> getHead()
        {
            return _head;
        }

        public Node<Type> getTail()
        {
            return _tail;
        }

        public void removeFirst()
        {
            if (_size != 0)
            {
                _head = _head.getNext();
                _size--;
            }

            if (_size == 0)
            {
                _tail = null;
            }
        }

        public void removeLast()
        {
            if (_size != 0)
            {
                if (_size == 1)
                {
                    _head = null;
                    _tail = null;
                }
                else
                {
                    Node<Type> current = _head;

                    while (current.getNext() != _tail)
                    {
                        current = current.getNext();
                    }

                    current.setNext(null);
                    _tail = current;
                }

                _size--;
            }
        }

        public Type getFirst()
        {
            return getHead().getValue();
        }

        /*
            four scenario
            1. empty list- do nothing
            2. single node : (previous is null)
            3. Many nodes
                a. node to remove is first node
                b. node to remove the middle or last
        */

        public bool remove(Type type)
        {
            Node<Type> prev = null;
            Node<Type> current = _head;

            while (current != null)
            {
                if (current.getValue().Equals(type))
                {
                    if (prev != null)
                    {
                        // just skip the current node. it works fine
                        prev.setNext(current.getNext());

                        if (current.getNext() == null)
                        {
                            _tail = prev;
                        }

                        _size--;
                    }
                    else
                    {
                        removeFirst();
                    }

                    return true;
                }

                prev = current;
                current = current.getNext();
            }

            return false;
        }

        public long getSize()
        {
            return _size;
        }

        public void print()
        {
            Console.Write($"Total elements ({_size}) : ");
            Node<Type> node = _head;

            while (node != null)
            {
                Console.Write($"{node.getValue()}, ");
                node = node.getNext();
            }

            Console.WriteLine();
        }

        public void clear()
        {
            for (Node<Type> x = _head; x != null;)
            {
                Node<Type> next = x.next;
                x.next = null;
                x = next;
            }

            _head = _tail = null;
            _size = 0;
        }
    }
}
