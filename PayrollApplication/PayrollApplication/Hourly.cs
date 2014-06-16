using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApplication
{
    class Hourly : Employee
    {
        private int hoursWorked;

        public Hourly()
        {
        }

        public Hourly(string firstName, string lastName, string emailAddress, string ssn, decimal payRate, int hoursWorked)
            : base(firstName, lastName, emailAddress, ssn, payRate)
        {
            this.hoursWorked = hoursWorked;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("    Hourly\n");
            sb.Append(base.ToString());

            return sb.ToString();
        }

        public override decimal Pay()
        {
            if (this.hoursWorked > 40)
                return 40M * this.PayRate + ((this.hoursWorked - 40) * (1.5M * this.PayRate));
            else
                return this.hoursWorked * this.PayRate;
        }
    }
}
