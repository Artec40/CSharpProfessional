using System;
using System.IO;
using System.Threading;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            object blok = new object();

            
            // Создаём 2 файла для многопоточной работы.
            #region
            FileStream firstStream = new FileStream("firstFile.txt", FileMode.Create);
            StreamWriter firstStreamWriter = new StreamWriter(firstStream);
            firstStreamWriter.Write("This sentence was written in first document!");
            firstStreamWriter.Close();
            firstStream.Close();

            FileStream secondStream = new FileStream("secondFile.txt", FileMode.Create);
            StreamWriter secondStreamWriter = new StreamWriter(secondStream);
            secondStreamWriter.Write("This sentence was written in second document!");
            secondStreamWriter.Close();
            secondStream.Close();
            #endregion
            
            // Создаём файл, в который запишем результат.
            #region
            FileStream resultStream = new FileStream("resultText.txt", FileMode.Create);
            StreamWriter resultStreamWriter = new StreamWriter(resultStream);
            #endregion
            
            //Метод, который передаётся делегату ThreadStart, для выполнения в первом потоке.
            void WorkOnFirstFile()
            {
                StreamReader firstStreamReader = File.OpenText("firstFile.txt");
                string fileText = firstStreamReader.ReadToEnd();
                firstStreamReader.Close();
                Console.WriteLine(fileText);
                lock (blok)
                {
                    resultStreamWriter.WriteLine(fileText);
                }
            }

            //Метод, который передаётся делегату ThreadStart, для выполнения во втором потоке.
            void WorkOnSecondFile()
            {
                StreamReader secondStreamReader = File.OpenText("secondFile.txt");
                string fileText = secondStreamReader.ReadToEnd();
                secondStreamReader.Close();
                Console.WriteLine(fileText);
                lock (blok)
                {
                    resultStreamWriter.WriteLine(fileText);
                }
            }
            
            // Создание первого потока.
            Thread firstThread = new Thread(new ThreadStart(WorkOnFirstFile));
            firstThread.Start();
            
            // Создание второго потока.
            Thread secondThread = new Thread(new ThreadStart(WorkOnSecondFile));
            secondThread.Start();

            // Первичный поток (метод Main()) ожидает окончания созданных потоков.
            firstThread.Join();
            secondThread.Join();
            
            resultStreamWriter.Close();
            resultStream.Close();
 }
    }
}