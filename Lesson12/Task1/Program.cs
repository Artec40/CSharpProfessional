using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Task1
{
    class Program
    {
        // метод SomeAction() имитирует выполнение программы.
        #region SimulationOfProgramExecution

        private static void SomeAction()
        {
            mutex.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Action {i}");
                Thread.Sleep(500);
            }
            mutex.ReleaseMutex();
        }
        #endregion
        static Mutex mutex = new Mutex(true, "MyMutex");
            
        static void Main(string[] args)
        {
            SomeAction();
        }
    }
}