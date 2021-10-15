using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class E : B
    {
        public int keysOnMouse = 2;
        public override void NewLVL(int n1)
        {
            __lvl += keysOnMouse;
        }
    }
}
