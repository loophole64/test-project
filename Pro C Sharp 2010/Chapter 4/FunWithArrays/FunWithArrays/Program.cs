using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");

            SimpleArrays();

            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Assign an array of ints containing 3 elements {0, 1, 2}
            int[] myInts = {100, 200, 300};
            foreach (int i in myInts)
                Console.WriteLine(i);

            // Initialize a 100 string array, indexed {0 - 99}
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }
    }
}
