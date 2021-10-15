using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    class Cat : Animal
    {
        public Cat(string Name) : base(Name)
        {
            __name = Name;
        }

        public void saySomething(string Mood)
        {
            // Mood can be happy or angry

            Debug.WriteLine(Mood.GetType());

            if (Mood == "happy")
            {
                Console.WriteLine("Mrrrrrr..");
            }

            else
            {
                Console.WriteLine("Shhhhhhh!");
            }
        }

    }
}
