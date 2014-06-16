using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create list of staffmembers
            List<StaffMember> staff = new List<StaffMember>();

            // add volunteer
            Console.WriteLine("adding volunteer");
            Volunteer vol = new Volunteer("VolunteerFirstName", "VolunteerLastName", "volunteer@org.TLD");
            staff.Add(vol);
            // add executive with good profits
            Console.WriteLine("adding executive with good profits");
            Executive goodExec = new Executive("GoodExecFirstName", "GoodExecLastName", "goodexecutive@org.TLD", "111-111-1111", 10000M);
            goodExec.CalculateBonus(1000000M);
            staff.Add(goodExec);
            // add executive with ok profits
            Console.WriteLine("adding executive with ok profits");
            Executive okExec = new Executive("OKExecFirstName", "OKExecLastName", "okexecutive@org.TLD", "555-555-5555", 10000M);
            okExec.CalculateBonus(1000M);
            staff.Add(okExec);
            // add executive with negative profits
            Console.WriteLine("adding executive with negative profits");
            Executive zeroExec = new Executive("ZeroExecFirstName", "ZeroExecLastName", "zeroexecutive@org.TLD", "666-66-6666", 10000M);
            zeroExec.CalculateBonus(-1000M);
            staff.Add(zeroExec);
            // add hourly
            Console.WriteLine("adding hourly employee");
            Hourly norm = new Hourly("NormFirstName", "NormLastName", "norm@org.TLD", "222-222-2222", 7.25M, 29);
            staff.Add(norm);
            // add overworked hourly
            Console.WriteLine("adding overworked employee");
            Hourly over = new Hourly("OverFirstName", "OverLastName", "over@org.TLD", "333-333-3333", 9M, 45);
            staff.Add(over);
            // add hourly with less than 0 hours
            Console.WriteLine("adding hourly employee with less than 0 hours");
            try
            {
                Hourly under = new Hourly("UnderFirstName", "UnderLastName", "under@org.TLD", "444-44-4444", 7.25M, -5);
                staff.Add(under);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // create employee (hourly) with less than zero payrate
            Console.WriteLine("adding hourly employee with negative payrate");
            try
            {
                Hourly poor = new Hourly("PoorFirstName", "PoorLastName", "poor@org.TLD", "666-666-6666", -10M, 60);
                staff.Add(poor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // iterate through list of staffmembers and print member and pay
            Console.WriteLine("\n\nStaff List:");
            foreach (StaffMember item in staff)
            {
                Console.Write(item.ToString());
                Console.WriteLine("Pay: {0:c}", item.Pay());
            }

            Console.ReadLine();
        }
    }
}
