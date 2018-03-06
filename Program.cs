using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            string h1 = "Type 3 entries, press enter after each entry";
            string e1;
            string e2;
            string e3;

            Console.WriteLine(h1);
            e1 = Console.ReadLine();
            e2 = Console.ReadLine();
            e3 = Console.ReadLine();
            Console.WriteLine("\n1. " + e1);
            Console.WriteLine("2. " + e2);
            Console.WriteLine("3. " + e3);




            Console.ReadLine(); // Keeps the console open by waiting for enter

        }
    }
}
