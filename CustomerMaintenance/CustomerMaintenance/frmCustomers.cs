using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    // (c) 2010 by Mike Murach & Associates, Inc. 
  
    public partial class frmCustomers : Form
    {
        //private List<Customer> customers = null;
        CustomerList cl = new CustomerList();

        public frmCustomers()
        {
            InitializeComponent();
            cl.Changed += new CustomerList.ChangeHandler(listChange);
        }

        private void listChange(CustomerList cl)
        {
            cl.Save();
            FillCustomerListBox();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            cl.Fill();
            FillCustomerListBox();
        }

        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            for (int i = 0; i < cl.Count; i++)
            {
                lstCustomers.Items.Add(cl[i].GetDisplayText());
            }
            //foreach (Customer c in customers)
            //{
            //    lstCustomers.Items.Add(c.GetDisplayText());
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            Customer customer = addCustomerForm.GetNewCustomer();
            if (customer != null)
            {
                cl.Add(customer);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            if (i != -1)
            {
                Customer customer = cl[i];
                string message = "Are you sure you want to delete "
                    + customer.FirstName + " " + customer.LastName + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    cl.Remove(customer);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}