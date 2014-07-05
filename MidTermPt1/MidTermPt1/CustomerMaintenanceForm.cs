using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MidTermPt1
{
    public partial class CustomerMaintenanceForm : Form
    {

        private List<Customer> customers = new List<Customer>();

        public CustomerMaintenanceForm()
        {
            InitializeComponent();
        }

        private void FillCustomerListBox()
        {
            listBoxCustomers.Items.Clear();
            foreach (Customer item in customers)
            {
                listBoxCustomers.Items.Add(item.GetDisplayText());
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int i = listBoxCustomers.SelectedIndex;
            if (i != -1)
            {
                Customer customer = customers[i];
                string message = "Are you sure you want to delete "
                    + customer.FirstName + " " + customer.LastName + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                    customers.Remove(customer);
                FillCustomerListBox();
            }
            
        }

        private void buttonAddWholesale_Click(object sender, EventArgs e)
        {
            AddWholesaleForm addWholesaleFrom = new AddWholesaleForm();
            Customer customer = addWholesaleFrom.GetNewCustomer();
            if (customer != null)
            {
                customers.Add(customer);
                FillCustomerListBox();
            }
        }

        private void buttonAddRetail_Click(object sender, EventArgs e)
        {
            AddRetailForm addRetailFrom = new AddRetailForm();
            Customer customer = addRetailFrom.GetNewCustomer();
            if (customer != null)
            {
                customers.Add(customer);
                FillCustomerListBox();
            }
        }
    }
}
