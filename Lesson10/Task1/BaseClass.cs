using System;

namespace Task1
{
    public class BaseClass
    {
        public void NonVirtualInterfaceMethod()
        {
            FirstMethod();
            SecondMethod();
        }

        protected virtual void FirstMethod()
        {
            Console.WriteLine("First method in base class");
        }

        protected virtual void SecondMethod()
        {
            Console.WriteLine("Second method in base class");
        }
    }
}