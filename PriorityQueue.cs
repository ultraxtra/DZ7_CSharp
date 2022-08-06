using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DZ7_CSharp
{
    internal class Node<T>
    {
        public T? _value;
        private Node<T> _next;
        private Node<T> _prev;
        private int _priority;
        public T ? Value { get; set; }
        public Node<T> Next { get; set; }
        public int Priority { get; set; }
        public Node<T> Prev { get; set; }

        public Node(T? value, int priority)
        {
            Value = value;
            Priority = priority;
        }

        public Node()
        {
            _value = default(T);
        }

        public Node(T value)
        {
            _value = value;
        }
    }

    internal class Queue<T>
    {
        public Node<T> Head;
        public int amount;
        public Queue()
        {
            Head = new Node<T>();
            amount = 0;
        }

        public T Peek()
        {
            return this.Head.Value;
        }

        public void Push(T value, int Priority)
        {
            Node<T> node_elem = new Node<T>(value, Priority);
            if(this.Head == null || Head.Priority< Priority)
            {
                node_elem.Next = this.Head;
                Head = node_elem;
            }
            else
            {
                Node<T> buff = Head;
                while(buff.Next!= null && buff.Next.Priority <= Priority)
                {
                    buff = buff.Next;
                    node_elem.Next = buff.Next;
                    buff.Next = node_elem;

                }
            }
            this.amount++;
        }
        public void Pop()
        {
            Node<T> node_elem = this.Head;
            if(node_elem == null)
            {
                this.Head = null;
            }
            else
            {
                this.Head = this.Head.Next;
            }
            this.amount--;
        }

        public void Print()
        {
            int Count = this.amount;
            Node<T> node_elem = this.Head;
            while(Count != 0)
            {
                Write($"{node_elem.Value}");
                Count--;
                node_elem = node_elem.Next;
            }
        }
    } 
}

