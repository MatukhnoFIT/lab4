using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    class Animal
    {
        public string __name;
        public Animal(string Name = "null")
        {
            __name = Name;
        }

        public void isAnimalFast(int countOfPaws, int speed)
        {
            Debug.WriteLine(countOfPaws);
            Debug.Write(speed);

            if (countOfPaws >= 4 & speed >= 10)
            {

                Console.WriteLine($"{ __name} is fast animal");

            }
            else
            {
                Console.WriteLine($"{__name} is slow animal");
            }
        }

    }
}
