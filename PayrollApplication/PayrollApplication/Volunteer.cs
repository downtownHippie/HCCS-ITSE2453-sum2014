using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApplication
{
    class Volunteer : StaffMember
    {
        public Volunteer()
        {
        }

        public Volunteer(string firstName, string lastName, string emailAddress)
            : base(firstName, lastName, emailAddress)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("    Volunteer\n");
            sb.Append(base.ToString());

            return sb.ToString();
        }

        public override decimal Pay()
        {
            return 0M;
        }
    }
}
