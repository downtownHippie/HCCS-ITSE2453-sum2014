using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQuery
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, decimal annualSalary)
        {
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = annualSalary;
        }

        public override string ToString()
        {
            return LastName + ", " + FirstName + ": " + AnnualSalary.ToString("c");
        }
    }
}
