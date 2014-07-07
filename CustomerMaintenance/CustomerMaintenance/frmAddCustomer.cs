using System;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    // (c) 2010 by Mike Murach & Associates, Inc. 
   
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private Customer customer = null;

        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                customer = new Customer(txtFirstName.Text, txtLastName.Text, txtEmail.Text);
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtFirstName) &&
                Validator.IsPresent(txtLastName) &&
                Validator.IsPresent(txtEmail) &&
                Validator.IsValidEmail(txtEmail);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}