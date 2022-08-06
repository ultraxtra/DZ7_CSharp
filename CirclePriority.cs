using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DZ7_CSharp
{
    internal class CirclePriority<T>
    {
        public Node<T> Head;
        public Node<T> Tail;
        public int? Count;
        public int? MaxAmount;
        public CirclePriority(int ?  maxAmount)
        {
            Head = new Node<T>();
            Tail = new Node<T>();
            Count = 0;
            MaxAmount = maxAmount;
        }

        public bool IsFull()
        {
            return this.Count == this.MaxAmount;
        }

        public void Push(T value)
        {
            if (!IsFull())
            {
                Node<T> node_elem = new Node<T>(value);
                if (this.Count == 0)
                {
                    this.Tail = this.Head = node_elem;
                }
                else
                {
                    this.Tail.Next = node_elem;
                    node_elem.Prev = this.Tail;
                    this.Tail = node_elem;
                }
                this.Count++;
            }          
        }

        public void Move()
        {
            Node<T> node_elem = this.Head;
            this.Head = this.Head.Next;
            if (this.IsFull())
            {
                this.Tail.Next = node_elem;
                node_elem.Prev = this.Tail;
                this.Tail = node_elem;
            }
        }
            public void Print()
             {
            int? Amount = this.Count;
            Node<T> node_elem = this.Head;
            while(Amount != 0)
            {
                Write($"{node_elem._value}");
                node_elem = node_elem.Next;
                Amount--;
            }
        }

        public void Pop()
        {
            Node<T> node_elem = this.Head;
            if (this.Head.Prev == null)
            {
                this.Tail = this.Head = null;
            }
            else
            {
                this.Head = node_elem.Prev;
                this.Head.Next = null;
            }
            this.Count--;

        }

      public T Peek()
        {
            return this.Head.Value;
        }
    }
}

