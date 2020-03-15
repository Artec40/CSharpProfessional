using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass myClass1 = new DerivedClass();
            
            // Шаблон NVI, позволяющий создать версионность.
            myClass1.NonVirtualInterfaceMethod();

            DerivedClass myClass2 = new DerivedClass();
            myClass2.NonVirtualInterfaceMethod();
        }
    }
}