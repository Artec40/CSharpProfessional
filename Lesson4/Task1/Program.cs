using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = File.ReadAllText("C:/Repositories/CSharpProfessional/Lesson4/Task1/someText.txt", Encoding.Default);
            Console.WriteLine(sentence);

            Console.WriteLine(new string('-',80));

            string pattern = @"\s[а-я]{1,3}\s";
            string sentenceNew = Regex.Replace(sentence, pattern, " ГАВ! ");
            Console.WriteLine(sentenceNew);
            File.WriteAllText("text_New.txt", sentenceNew, Encoding.Default);
            
        }
    }
}