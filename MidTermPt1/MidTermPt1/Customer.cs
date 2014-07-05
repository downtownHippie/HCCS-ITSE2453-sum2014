using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermPt1
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Customer()
        {
        }

        public Customer(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public virtual string GetDisplayText()
        {
            return FirstName + " " + LastName + " " + Email;
        }
    }
}
