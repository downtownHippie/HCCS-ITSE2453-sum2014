using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQQuery
{
    class Program
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee("John", "Smith", 100000m),
            new Employee("Mary", "Jones", 30000m),
            new Employee("Sam", "Spade", 60000m),
            new Employee("Melissa", "Perez", 25000m),
            new Employee("Jason", "Blue", 120000m),
            new Employee("Ben", "Strong", 18000m),
            new Employee("Wendy", "Indigo", 50000m),
            new Employee("James", "Green", 15000m)
        };


        static void Main(string[] args)
        {
            Console.WriteLine("All Employees:");
            foreach (var item in employees)
            {
                Console.WriteLine("\t" + item.ToString());
            }

            Console.WriteLine("\nEmployees making under $40,000 per year");
            var poorEmployees = from e in employees
                                where e.AnnualSalary < 40000
                                select e;
            foreach (var item in poorEmployees)
            {
                Console.WriteLine("\t" + item.ToString());
            }

            Console.WriteLine("\nEmployees making between $50,000 and $100,000 per year (non-inclusive)");
            var middleClass = from e in employees
                              where e.AnnualSalary > 50000 && e.AnnualSalary < 100000
                              select e;
            foreach (var item in middleClass)
            {
                Console.WriteLine("\t" + item.ToString());
            }

            Console.WriteLine("\nEmployee last and first names, sorted by last then by first");
            var names = from e in employees
                        orderby e.LastName, e.FirstName
                        select new { e.LastName, e.FirstName };
            foreach (var item in names)
            {
                Console.WriteLine("\t" + item.ToString());
            }

            Console.WriteLine("\nEmployee last names, in uppercase, that start with S");
            var lasts = from e in employees
                        let n = e.LastName.ToUpper()
                        where n.StartsWith("S")
                        select n;
            foreach (var item in lasts)
            {
                Console.WriteLine("\t" + item.ToString());

            }

            Console.ReadLine();
        }
    }
}
