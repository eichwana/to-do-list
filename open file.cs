using System;

namespace open_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "C:\\codetest\\";

            Console.WriteLine("Do you have an existing file?");
            string filee = Console.ReadLine();
            if (filee.Trim() == "n" | filee.Trim() == "no" | filee.Trim() == "0" | filee.Trim() == "N" | filee.Trim() == "No")
            {
                Console.WriteLine("What is your name?");
                String name = Console.ReadLine();
                Console.WriteLine("Hello " + name + ", type your entries and press enter after each one");
                string e1 = Console.ReadLine();
                string e2 = Console.ReadLine();
                string e3 = Console.ReadLine();
                
                System.IO.Directory.CreateDirectory(filepath);
                string[] entries = { e1, e2, e3 };
                System.IO.File.WriteAllLines(filepath + name + ".txt", entries);
                Console.WriteLine("See " + filepath + name + ".txt");
            }
            else if (filee.Trim() == "y" | filee.Trim() == "Y" | filee.Trim() == "yes" | filee.Trim() == "1" | filee.Trim() == "Yes")
            {
                Console.WriteLine("What is your filename?");
                string efile = Console.ReadLine();
                string lines = System.IO.File.ReadAllText(filepath + efile + ".txt");
                Console.WriteLine(lines);
            }
            else
            {
                Console.WriteLine("Sorry, I don't understand...");
            }

            Console.ReadLine(); // Keeps the console open by waiting for enter
        }
    }
}
