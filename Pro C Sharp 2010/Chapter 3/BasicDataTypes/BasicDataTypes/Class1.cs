using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class Program
    {
        static void Main()
        {
            LocalVarDeclarations();
            Console.ReadLine();
        }

        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            int myInt = 0;
            string myString = "This is my character data.";
            bool b1 = true, b2 = false, b3 = b1;

            Console.WriteLine("Data: {0}, {1}, {2}, {3}, {4}", myInt, myString, b1, b2, b3);
            
            Console.WriteLine();
        }
    }
}
