using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class D : B
    {
        public int years = 0;
        public override void NewLVL(int n1)
        {
            __lvl = n1 * years;
        }
    }
}
