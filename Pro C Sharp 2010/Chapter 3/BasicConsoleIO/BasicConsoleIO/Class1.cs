using System;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main()
        {
            GetUserData();
            FormatNumericalData(99999);
            Console.ReadLine();
        }

        static void GetUserData()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

            Console.ForegroundColor = prevColor;
        }

        static void FormatNumericalData(int x)
        {
            Console.WriteLine("The Value {0} in various formats:", x);
            Console.WriteLine("c format: {0:c}", x);
            Console.WriteLine("d9 format: {0:d9}", x);
            Console.WriteLine("f3 format: {0:f3}", x);
            Console.WriteLine("n format: {0:n}", x);

            Console.WriteLine("E format: {0:E}", x);
            Console.WriteLine("e format: {0:e}", x);
            Console.WriteLine("X format: {0:X}", x);
            Console.WriteLine("x format: {0:x}", x);
        }
    }
}
