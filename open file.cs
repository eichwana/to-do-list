using System;
using System.Collections.Generic;
using System.IO;

namespace open_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "C:\\codetest\\";
            string errortext = "Sorry, I don't understand...";
            
            Console.WriteLine("Do you have an existing file?");
            string filee = Console.ReadLine();

            if (filee.Trim() == "n" | filee.Trim() == "no" | filee.Trim() == "0" | filee.Trim() == "N" | filee.Trim() == "No" | filee.Trim() == "niet")
            {
                List<string> entries2 = new List<string>();

                Console.WriteLine("\nWhat is your name?");
                String name = Console.ReadLine();
                Console.WriteLine("Hello " + name + ", how many entries do you have?");
                string num = Console.ReadLine();
                if (int.TryParse(num, out int num2))
                {
                    Console.WriteLine("Please type your " + num + " entries, pressing enter after each one");

                    for (int n = 1; n <= num2; n++)
                    {
                        string e = Console.ReadLine();
                        entries2.Add(e);
                    }

                    Directory.CreateDirectory(filepath);
                    File.WriteAllLines(filepath + name + ".txt", entries2);
                    Console.WriteLine("See " + filepath + name + ".txt");
                }
                else
                {
                    Console.WriteLine(errortext);
                }
            }
               
                

            else if (filee.Trim() == "y" | filee.Trim() == "Y" | filee.Trim() == "yes" | filee.Trim() == "1" | filee.Trim() == "Yes")
            {
                Console.WriteLine("\nWhat is your filename?");
                string efile = Console.ReadLine();
                string efile2 = filepath + efile + ".txt";
                if (File.Exists(efile2))
                {
                    string[] entries = File.ReadAllLines(efile2);
                    Console.WriteLine("\nContents of " + efile + "\n");
                    int n = 1;
                    foreach (string entry in entries)
                    {
                        Console.WriteLine(n + ". "  + entry);
                        n++;
                        
                    }
                }
                else
                {
                    Console.WriteLine(errortext);
                }
            }
            else
            {
                Console.WriteLine(errortext);
            }

            Console.ReadLine(); // Keeps the console open by waiting for enter
        }
    }
}
