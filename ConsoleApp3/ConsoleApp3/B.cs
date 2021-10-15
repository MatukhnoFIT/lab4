using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class B : A
    {
        public int num1 = 2;
        public int num2 { get; private set; }
        public B(string p1, string p2, int n2) : base(p1, p2)
        {
            num2 = n2;
        }
        public void Calc(int n)
        {
            Console.WriteLine(n + num1 + num2);
        }
    }
}
