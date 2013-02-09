using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson danny = new SalesPerson();
            danny.Age = 31;
            danny.Name = "danny";
            danny.SalesNumber = 51;
            Console.ReadLine();
        }
    }
}
