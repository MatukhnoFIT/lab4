using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class A
    {
        public string firstName { get; private set; }
        public string secondName { get; set; }
        public A(string s1, string s2)
        {
            firstName = s1;
            secondName = s2;
        }
    }
}
