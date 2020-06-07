using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("C:/Repositories/CSharpProfessional/Lesson3/Task1/NewFile.txt");
            
            StreamWriter writer = file.CreateText();
            writer.WriteLine("Hello!");
            writer.Close();
            
            StreamReader reader = file.OpenText();
            string input;
            while ((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            reader.Close();
        }
    }
}