using System;
using static System.Console;

namespace DZ7_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Program1();
            Program2();
            Program3();
        }

        public static void Program1()
        {
            int A = 10;
            int B = 70;
            WriteLine($"First:{A}\n Second:{B}");
            Swap<int>(ref A, ref B);
            WriteLine($"First:{A}\n Second:{B}");


        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

       public static void Program2()
        {
            try
            {
                Write("Queue: ");
                Random random = new Random();
                Queue<int> queue = new Queue<int>();
                for (int i = 0; i < 5; i++)
                {
                    queue.Push(i, i);
                }
                queue.Print();
                WriteLine();
                WriteLine($"Peek: {queue.Peek()}");
                queue.Pop();
                queue.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public static void Program3()
        {
            try
            {
                Write("Queue: ");
                Random random = new Random();
                CirclePriority<int> queue = new CirclePriority<int>(5);
                for (int i = 0; i < 5; i++)
                {
                    queue.Push(i);
                }
                queue.Print();
                queue.Move();
                WriteLine("Queue after moving: ");
                queue.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}