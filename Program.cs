using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            string nametext;
            string nameshow = "Write your name:";
            string h1 = "Type 3 entries, press enter after each entry";
            string e1;
            string e2;
            string e3;

            Console.WriteLine(nameshow);
            nametext = Console.ReadLine();
            Console.WriteLine(h1);
            e1 = Console.ReadLine();
            e2 = Console.ReadLine();
            e3 = Console.ReadLine();
            Console.WriteLine("\n1. " + e1);
            Console.WriteLine("2. " + e2);
            Console.WriteLine("3. " + e3);
            string filepath = "C:\\codetest\\";
            string[] entries = { e1, e2, e3 };
            System.IO.File.WriteAllLines(filepath + nametext + ".txt", entries);
            Console.WriteLine("See "+filepath + nametext + ".txt");

            Console.ReadLine(); // Keeps the console open by waiting for enter

        }
    }
}
