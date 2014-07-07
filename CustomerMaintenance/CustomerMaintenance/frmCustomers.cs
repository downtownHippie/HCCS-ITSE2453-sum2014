using System;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    // (c) 2010 by Mike Murach & Associates, Inc. 

    public partial class frmCustomers : Form
    {
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
                lstCustomers.Items.Add(cl[i].GetDisplayText());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new frmAddCustomer().GetNewCustomer();
            if (customer != null)
                cl += customer;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((lstCustomers.SelectedIndex != -1) &&
                    (MessageBox.Show("Are you sure you want to delete "
                    + cl[lstCustomers.SelectedIndex].FirstName + " "
                    + cl[lstCustomers.SelectedIndex].LastName + "?",
                    "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes))
                cl -= cl[lstCustomers.SelectedIndex];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex != -1)
                cl[lstCustomers.SelectedIndex] = 
                    new frmEditCustomer(cl[lstCustomers.SelectedIndex]).GetCustomer();
        }
    }
}