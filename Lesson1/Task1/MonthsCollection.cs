using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task1
{
    class MonthsCollection : IEnumerable, IEnumerator
    {
        readonly Month[] months = {
            new Month(1, 31),
            new Month(2, 28),
            new Month(3, 31),
            new Month(4, 30),
            new Month(5, 31),
            new Month(6, 30),
            new Month(7, 31),
            new Month(8, 31),
            new Month(9, 30),
            new Month(10, 31),
            new Month(11, 30),
            new Month(12, 31)
        };

        public Month this[int index]
        {
            get { return months[index]; }
            set { months[index] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        int position = -1;

        public object Current
        {
            get
            {
                return months[position];
            }
        }

        public bool MoveNext()
        {
            while (position < (months.Length - 1))
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public int GetDaysByMonth(int month)
        {
            int dayValue = 0;
            foreach (Month m in months)
            {
                if (month == m.MonthNumber)
                    dayValue = m.DayInMunth;
            }
            return dayValue;
        }

        public Queue GetMonthByDays(int days)
        {
            Queue monthValue = new Queue { };
            foreach (Month m in months)
            {
                if (days == m.DayInMunth)
                    monthValue.Enqueue(m.MonthNumber);
            }
            return monthValue;
        }
    }
}
