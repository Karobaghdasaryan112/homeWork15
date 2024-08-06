using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    internal class CustomLinkedList<T> : IEnumerable<T>
    {
        private Node _tail;
        private Node _head;
        private class Node
        {
            public T Value;
            public Node Next;
            public Node(T value)
            {
                this.Value = value;
                Next = null;
            }
        }
        public void Add(T value)
        {
            Node New = new Node(value);
            if (_tail == null)
            {
                _tail = New;
                _head = New;
            }
            else
            {
                _tail.Next = New;
                _tail = New;
            }
        }
        public void Remove(T value)
        {
            if (_head == null)
            {
                return;
            }
            else
            {
                Node current = _head;
                while (current.Next != null)
                {
                    if (_head.Value.Equals(value))
                    {
                        _head = current.Next;
                        if (_head == null)
                        {
                            _tail = null;
                        }
                        return;
                    }
                    if (current.Next.Value.Equals(value))
                    {
                        if (current.Next == _tail)
                        {
                            _tail = current;
                            current.Next = null;
                            return;
                        }
                        current.Next = current.Next.Next;
                        return;
                    }
                    current = current.Next;
                }
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node node = _head;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
