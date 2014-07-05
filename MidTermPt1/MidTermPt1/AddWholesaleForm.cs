using System;
using System.Windows.Forms;

namespace MidTermPt1
{
    public partial class AddWholesaleForm : Form
    {
        private WholesaleCustomer customer = null;

        public AddWholesaleForm()
        {
            InitializeComponent();
        }

        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(textBoxFirstName) &&
                Validator.IsPresent(textBoxLastName) &&
                Validator.IsPresent(textBoxEmail) &&
                Validator.IsValidEmail(textBoxEmail) &&
                Validator.IsPresent(textBoxCompany);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                customer = new WholesaleCustomer(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxCompany.Text);
                this.Close();
            }
        }
    }
}
