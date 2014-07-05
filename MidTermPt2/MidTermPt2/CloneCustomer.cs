using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MidTermPt2
{
    public partial class CloneCustomer : Form
    {
        private Customer customer;
        private List<Customer> customers;

        public CloneCustomer()
        {
            InitializeComponent();
        }

        private void CloneCustomer_Load(object sender, EventArgs e)
        {
            customer = new Customer("Joe", "Reid", "downtownHippie@gmail.com");
            textBoxInitialCustomer.Text = customer.GetDisplayText();
        }

        private void FillListBoxCustomerClones()
        {
            listBoxClonedCustomers.Items.Clear();
            foreach (Customer item in customers)
            {
                listBoxClonedCustomers.Items.Add(item.GetDisplayText());
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClone_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(textBoxNumCopies) && Validator.IsInt32(textBoxNumCopies))
            {
                int numCopies = Convert.ToInt32(textBoxNumCopies.Text);
                customers = new List<Customer>(numCopies);
                for (int i = 0; i < numCopies; i++)
                {
                    customers.Add((Customer)customer.Clone());
                }
            }
            FillListBoxCustomerClones();
        }
    }
}
