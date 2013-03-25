using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        // Constructors
        public Manager() { }
        public Manager(string fullName, int age, int empId, float currPay, string ssn, int numOfOpts) : base(fullName, age, empId, currPay, ssn)
        {
            StockOptions = numOfOpts;
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        } 
    }
}
