using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApplication
{
    public abstract class StaffMember
    {
        private string firstName;
        private string lastName;
        private string emailAddress;

        public StaffMember()
        {
        }

        public StaffMember(string firstName, string lastName, string emailAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("FirstName: {0}\n", this.firstName);
            sb.AppendFormat("LastName: {0}\n", this.lastName);
            sb.AppendFormat("emailAddr: {0}\n", this.emailAddress);

            return sb.ToString();
        }

        public abstract decimal Pay();
    }
}
