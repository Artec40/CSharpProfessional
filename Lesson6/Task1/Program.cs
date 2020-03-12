using System;
using System.IO;
using System.Reflection;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Загрузка сборки.
            Assembly assembly =
                Assembly.LoadFile(
                    "C:/Repositories/CSharpProfessional/Lesson6/Task1Helper/bin/Debug/netcoreapp3.1/Task1Helper");
            
            // Создание экземпляра из загруженой сборки.
            dynamic instance = Activator.CreateInstance(assembly.GetType("Task1Helper.Temperature"));
            
            // Вызов метода на загруженом экземпляре.
            Console.WriteLine(instance.Fahrenheit(15));
            }
    }
}