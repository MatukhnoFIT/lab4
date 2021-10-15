using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class B
    {
        public string Nick = "HiDie";
        public int __lvl = 1;
        public B()
        {
            Console.WriteLine();

        }
        public virtual void NewLVL(int n1)
        {
            __lvl = n1;
        }
    }
}
