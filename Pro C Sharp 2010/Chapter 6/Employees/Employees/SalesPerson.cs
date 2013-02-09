using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        // Constructors
        public SalesPerson() { }
        public SalesPerson(string fullName, int age, int empId, float currPay, string ssn, int numOfSales) : base(fullName, age, empId, currPay, ssn)
        {
            SalesNumber = numOfSales;
        }
    }
}
