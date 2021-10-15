using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class C : B
    {
        public int skill = 0;
        public override void NewLVL(int n1)
        {
            __lvl += skill * n1;
        }
    }
}
