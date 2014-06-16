using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApplication
{
    class Executive : Employee
    {
        private decimal bonus;

        public Executive()
        {
        }

        public Executive(string firstName, string lastName, string emailAddress, string ssn, decimal payRate)
            : base(firstName, lastName, emailAddress, ssn, payRate)
        {
        }
        
        public void CalculateBonus(decimal netProfit)
        {
            if (netProfit > this.PayRate)
                this.bonus = this.PayRate * 0.03M;
            else if (netProfit > 0)
                this.bonus = this.PayRate * 0.01M;
            else
                this.bonus = 0M;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("    Executive\n");
            sb.Append(base.ToString());

            return sb.ToString();
        }

        public override decimal Pay()
        {
            return this.PayRate + this.bonus;S
        }
    }
}
