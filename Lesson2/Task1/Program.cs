using System;
using System.Collections;
using System.Collections.Specialized;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection buyers = new NameValueCollection();
            buyers.Add("Andrey","Guitar");
            buyers.Add("Andrey","Piano");
            buyers.Add("Aleksandr","Guitar");
            buyers.Add("Aleksandr","Drums");

            // Получить все наименования продукта ("имя") по имени покупателя "ключ".
            foreach (string product in buyers.GetValues("Andrey"))
            {
                Console.WriteLine($"product = {product}");
            }

            // Получить все имена покупателей ("ключ") по наименованию продукта ("имя").
            foreach (string keys in buyers.AllKeys) 
            {
                if (buyers[keys]=="Guitar");  
                Console.WriteLine($"name = {keys}");
            }
        }
    }
}
