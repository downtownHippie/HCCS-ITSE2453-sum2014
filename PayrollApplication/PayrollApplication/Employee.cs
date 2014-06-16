using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApplication
{
    class Employee : StaffMember
    {
        private string ssn;
        private decimal payRate;

        public decimal PayRate
        {
            get
            {
                return this.payRate;
            }
            set
            {
                this.payRate = value;
            }
        }

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, string emailAddress, string ssn, decimal payRate)
            : base(firstName, lastName, emailAddress)
        {
            this.ssn = ssn;
            if (payRate <= 0M)
            {
                throw new ArgumentOutOfRangeException("payRate", "payRate must be greater than zero");
            }
            else
                this.PayRate = payRate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendFormat("SSN: {0}\n", this.ssn);

            return sb.ToString();
        }

        public override decimal Pay()
        {
            return this.payRate;
        }
    }
}
