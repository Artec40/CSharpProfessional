using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthsCollection months = new MonthsCollection();

            foreach (Month m in months)
            {
                Console.WriteLine($"m.MonthNumber = {m.MonthNumber}, m.DayInMunth = {m.DayInMunth}");
            }

            Console.WriteLine($"MonthNumber = {months.GetDaysByMonth(5)}");

            foreach (int m in months.GetMonthByDays(30))
            {
                Console.WriteLine($"Month = {m}");
            }
        }
    }
}
