using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter license key: ");
            string key = Console.ReadLine();
            ApplicationLicense myApp = new ApplicationLicense(key);
            Console.WriteLine("Start Work?: (press any key)");
            Console.ReadKey();
            if (myApp.typeVersion != "free")
            {
                while (true)
                {
                    Console.WriteLine($"{myApp.typeVersion} version working");
                }
            }
            else
            {
                Console.WriteLine("You are using the free version. Upgrade your license or try a trial period");
            }

        }
    }
}
