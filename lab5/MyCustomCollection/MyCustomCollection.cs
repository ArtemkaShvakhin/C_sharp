using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class MyCustomCollections<T> : ICustomCollection<T>
    {
        class Node
        {
            public Node next;
            public T _data;
            public Node(T data)
            {
                _data = data;
            }
            public Node()
            {

            }
        }
        private Node head;
        private Node current;
        private int size;
        public MyCustomCollections()
        {
            head = null;
            current = null;
            size = 0;
        }
        public void Reset()
        {
            if (size == 0)
            {
                throw new Exception("There is no elements in collection!");
            }
            current = head;
        }
        public void Next()
        {
            if (size == 0)
            {
                throw new Exception("There is no elements in collection!");
            }
            current = current?.next;
        }
        public T Current()
        {
            if (size == 0)
            {
                throw new Exception("There is no elements in collection!");
            }
            else if (current == null)
            {
                throw new ArgumentNullException();
            }
            return current._data;
        }
        public int Count()
        {
            return size;
        }
        public void Add(T item)
        {
            Node temp = new Node(item);
            if (head == null)
            {
                temp.next = null;
                head = temp;
                size++;
            }
            else
            {
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new Node(item);
                size++;
            }
        }
        public void Remove(T item)
        {
            if (size == 0)
            {
                throw new Exception("There is no elements in collection!");
            }
            else
            {
                Node temp = new Node();
                if (head._data.Equals(item))
                {
                    head = head.next;
                    size--;
                }
                temp = head;
                while (temp.next != null)
                {
                    if (temp.next._data.Equals(item))
                    {
                        temp.next = temp.next.next;
                        size--;
                    }
                    else
                        temp = temp.next;
                }
                if (temp._data.Equals(item))
                {
                    temp = null;
                    size--;
                }
            }
        }
        public T RemoveCurrent()
        {
            if (size == 0)
            {
                throw new Exception("There is no elements in collection!");
            }
            else if (current == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                if (head == current)
                {
                    head = head.next;
                    size--;
                }
                else
                {
                    Node temp = new Node();
                    temp = head;
                    while (temp.next != current)
                    {
                        temp = temp.next;
                    }
                    temp.next = temp.next.next;
                    size--;
                }
            }
            return current._data;
        }
        public void Print()
        {
            if (size == 0)
            {
                throw new Exception("Error! There is no elements in collection");
            }
            else
            {
                Node temp = current;
                current = head;
                for (int i = 0; i < size; i++)
                {
                    Console.Write(current._data + " ");
                    current = current.next;
                }
                current = temp;
            }
            Console.WriteLine();
        }
        public T this [int index]
        {
            get
            {
                Node temp = head;
                for (int i = 0; i < index; ++i)
                {
                    temp = temp.next;
                }
                return temp._data;
            }
            set
            {
                Node temp = head;
                for (int i = 0; i < index; ++i)
                {
                    temp = temp.next;
                }
                temp._data = value;
            }
        }
    }
}
