using System;
using System.Diagnostics;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A("zx", "cxs");
            B b = new B("t", "r", 23);
            b.Calc(5);
            Debug.WriteLine(b.num2);
            Debug.WriteLine(b.num1);
            Console.Read();
        }
    }
}
