using System;
using System.Threading;

namespace Task1
{
    class Program
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.GetHashCode());
            
            Action myDelegate = new Action(SomeAction);
            myDelegate.BeginInvoke(CallBack,"Text");
            
            Console.WriteLine(Thread.CurrentThread.GetHashCode());

            void SomeAction()
            {
                Console.WriteLine(Thread.CurrentThread.GetHashCode());
            }

            void CallBack(IAsyncResult asyncResult)
            {
                Console.WriteLine(Thread.CurrentThread.GetHashCode());
                Console.WriteLine(asyncResult.AsyncState);
            }
        }
    }
}