using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a simple message.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Process incoming args.
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine("Arg " + i.ToString() + ": {0}", args[i]);

            ShowEnvironmentDetails();

            Console.ReadLine();
        }

        static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.ForegroundColor += 1;
                Console.WriteLine("Drive: {0}", drive);
            }

            Console.ForegroundColor += 1;
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.ForegroundColor += 1;
            Console.WriteLine("# CPUs: {0}", Environment.ProcessorCount);
            Console.ForegroundColor += 1;
            Console.WriteLine(".Net Version: {0}", Environment.Version);
        }
    }
}