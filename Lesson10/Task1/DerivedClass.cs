using System;

namespace Task1
{
    public class DerivedClass : BaseClass
    {
        public new void NonVirtualInterfaceMethod()
        {
            FirstMethod();
            SecondMethod();
        }
        // Замещение метода. Инкапсуляция не работает.
        protected new void FirstMethod()
        {
            Console.WriteLine("First method in derived class");
        }

        // Переопределение метода.
        protected override void SecondMethod()
        {
            Console.WriteLine("Second method in derived class");
        }
    }
}