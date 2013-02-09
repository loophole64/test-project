using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    class Employee
    {
        // Field Data
        protected string empName;
        protected int empId;
        protected float currPay;
        protected int empAge;
        protected string empSsn;
        protected BenefitsPackage empBenefits = new BenefitsPackage();

        // Properties
        public int Id { get { return empId; } set { empId = value; } }
        public float Pay { get { return currPay; } set { currPay = value; } }
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name must be less than 16 characters!");
                else
                    empName = value;
            }
        }
        public int Age { get { return empAge; } set { empAge = value; } }
        public string SocialSecurityNumber { get { return empSsn; } protected set { empSsn = value; } }
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }
        public BenefitsPackage Benefits { get { return empBenefits; } set { empBenefits = value; } }


        // Constructors.
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay, "") { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
            SocialSecurityNumber = ssn;
        }

        // Methods
        public void GiveBonus(float amount) { Pay += amount; }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
        }
    }
}
