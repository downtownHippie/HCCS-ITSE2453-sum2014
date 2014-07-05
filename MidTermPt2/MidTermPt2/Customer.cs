using System;

namespace MidTermPt2
{
    // copied from MidTermPt1 as directed from assignment
    //   changed namespace (duh!)
    //   added and implemented interface

    // For what it's worth:
    // stackoverflow indicates that Microsoft recommends against implementing IClonable
    // http://stackoverflow.com/questions/699210/why-should-i-implement-icloneable-in-c

    public class Customer : ICloneable
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

        public string GetDisplayText()
        {
            return FirstName + " " + LastName + " " + Email;
        }

        public object Clone()
        {
            Customer newCustomer = (Customer)this.MemberwiseClone();
            // of course you could implement this by hand...
            //Customer newCustomer = new Customer();
            //newCustomer.FirstName = this.FirstName;
            //newCustomer.LastName = this.LastName;
            //newCustomer.Email = this.Email;
            // -- or --
            //Customer newCustomer = new Customer(this.FirstName, this.LastName, this.Email);
            
            // but in the end you still return newCustomer
            return newCustomer;
        }
    }
}
