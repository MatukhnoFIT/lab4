using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = new A(b);
            C b1 = new C();
            b1.NewLVL(12);
            Console.Read();
        }
    }
}
