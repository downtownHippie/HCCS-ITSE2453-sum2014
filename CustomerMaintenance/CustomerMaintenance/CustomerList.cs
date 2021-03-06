﻿using System.Collections.Generic;

namespace CustomerMaintenance
{
    class CustomerList
    {
        private List<Customer> customers = new List<Customer>();

        // no set method because Count isn't settable only gettable
        public int Count
        {
            get { return customers.Count; }
        }

        public Customer this[int i]
        {
            get { return customers[i]; }
            set { customers[i] = value; Changed(this); }
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
            Changed(this);
        }

        public static CustomerList operator +(CustomerList cl, Customer customer)
        {
            if (customer != null)
                cl.Add(customer);
            return cl;
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
            Changed(this);
        }

        public static CustomerList operator -(CustomerList cl, Customer customer)
        {
            if (customer != null)
                cl.Remove(customer);
            return cl;
        }

        public void Fill()
        {
            customers = CustomerDB.GetCustomers();
        }

        public void Save()
        {
            CustomerDB.SaveCustomers(customers);
        }

        public delegate void ChangeHandler(CustomerList cl);

        public event ChangeHandler Changed;

        protected virtual void OnChanged(CustomerList cl)
        {
            if (Changed != null)
                Changed(cl);
        }
    }
}
