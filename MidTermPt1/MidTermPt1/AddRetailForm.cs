using System;
using System.Windows.Forms;

namespace MidTermPt1
{
    public partial class AddRetailForm : Form
    {
        private RetailCustomer customer = null;

        public AddRetailForm()
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
                Validator.IsPresent(textBoxHomePhone) &&
                Validator.IsValidPhoneNumber(textBoxHomePhone);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                customer = new RetailCustomer(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxHomePhone.Text);
                this.Close();
            }
        }
    }
}
