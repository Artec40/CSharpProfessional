using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Month
    {
        public int MonthNumber { get; set; }
        public int DayInMunth { get; set; }


        public Month(int monthNumber, int dayInMunth)
        {
            MonthNumber = monthNumber;
            DayInMunth = dayInMunth;
        }
    }
}
