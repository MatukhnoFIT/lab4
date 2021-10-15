using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Murzik");
            Cat murzik = cat as Cat;

            murzik.isAnimalFast(4, 11);
            murzik.saySomething("happy");

            Console.ReadLine();
        }
    }
}
