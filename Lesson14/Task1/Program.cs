using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine($"Task 1 thread - {Thread.CurrentThread.ManagedThreadId.ToString()}");
            for (int i = 0; i < 40; i++)
            {
                Thread.Sleep(50);
                Console.Write("+");
            }
        }
        
        public static void Task2()
        {
            Console.WriteLine($"Task 2 thread - {Thread.CurrentThread.ManagedThreadId.ToString()}");
            for (int i = 0; i < 40; i++)
            {
                Thread.Sleep(50);
                Console.Write("-");
            }
        }
        
        static void Main(string[] args) 
        {
            Console.WriteLine($"Main thread - {Thread.CurrentThread.ManagedThreadId.ToString()}");
            Parallel.Invoke(Task1,Task2);
        }
    }
}