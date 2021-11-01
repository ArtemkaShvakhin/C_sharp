using System;

namespace Firma
{

        public class MyCustomCollection<T> //: ICustomCollection<T>
        {
            private class Node
            {
                public T Data { get; set; }

                public Node Next { get; set; }
                public Node(T data)
                {
                    if (data == null)
                    {
                        throw new ArgumentNullException(nameof(data));
                    }

                    Data = data;
                }


            }

            public int Count
            {
                get => count;
            }
            public MyCustomCollection(T data)
            {
                count = 0;
                Add(data);
            }

            public MyCustomCollection()
            {
                count = 0;
            }


            private Node head = null;

            private Node tail = null;

            private Node res = null;

            private int count = 0;

            public T this[int index]
            {
                get
                {
                    if (Count >= index)
                    {
                        int counter = 0;
                        Node current = head;
                        if (current != null)
                        {
                            while (counter < index)
                            {
                                counter++;
                                current = current.Next;
                            }
                            return current.Data;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                set
                {
                    if (Count >= index)
                    {
                        int counter = 0;
                        Node current = head;
                        while (counter - index >= 0)
                        {
                            counter++;
                            current = current.Next;
                        }
                        current.Data = value;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }

            public void Add(T data)
            {
                if (data == null)
                {
                    throw new ArgumentNullException(nameof(data));
                }
                var item = new Node(data);

                if (head == null)
                {
                    head = item;
                    res = item;
                }

                else
                {
                    tail.Next = item;
                }
                tail = item;

                count++;
            }

            public void Remove(T data)
            {
                if (data == null)
                {
                    throw new ArgumentNullException(nameof(data));
                }
                var current = head;

                Node previous = null;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        if (previous != null)
                        {//не середина
                            previous.Next = current.Next;
                            if (current.Next == null)
                            {
                                tail = previous;
                            }
                        }
                        else
                        {
                            head = head.Next;
                            if (head == null)
                            {
                                tail = null;
                            }
                        }
                        count--;
                        break;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            public void Reset()
            {
                res = head;
            }
            public void Next()
            {
                res = res.Next;
            }

            public T Current()
            {
                if (count == 0)
                {
                    throw new ArgumentNullException(nameof(count));
                }
                return res.Data;
            }

            public T RemoveCurrent()
            {
                return res.Data;
                var currentNew = head;

                Node previous = null;

                while (currentNew != null)
                {
                    if (currentNew.Data.Equals(Current()))
                    {
                        if (previous != null)
                        {//не середина
                            previous.Next = currentNew.Next;
                            if (currentNew.Next == null)
                            {
                                tail = previous;
                            }
                        }
                        else
                        {
                            head = head.Next;
                            if (head == null)
                            {
                                tail = null;
                            }
                        }
                        count--;
                        break;
                    }
                    previous = currentNew;
                    currentNew = res.Next;
                }
            }

            public void Clear()
            {
                head = null;
                tail = null;
                count = 0;
            }
        }
    }

