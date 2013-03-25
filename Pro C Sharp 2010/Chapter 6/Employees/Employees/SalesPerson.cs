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

        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }
    }
}
