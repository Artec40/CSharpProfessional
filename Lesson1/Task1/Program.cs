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

            months.GetDaysByMonth(5);
            months.GetMonthByDays(30);
        }
    }
}
