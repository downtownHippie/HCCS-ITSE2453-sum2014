using System;
using System.Windows.Forms;
using PropertyTypes;

namespace RentalPropertyManager
{
    public partial class frmAddOrEditSingle : Form
    {
        private SingleFamily single = null;

        public frmAddOrEditSingle()
        {
            InitializeComponent();
        }

        public frmAddOrEditSingle(SingleFamily single)
        {
            InitializeComponent();
            this.single = single;
            tbAddress.Text = this.single.Address;
            tbBuilder.Text = this.single.Builder;
            tbYearBulit.Text = this.single.YearBuilt.ToString();
            tbSquareFootage.Text = this.single.SquareFeet.ToString();
            tbRent.Text = this.single.Rent.ToString();
            cbGarage.Checked = this.single.HasGarage;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                single = new SingleFamily(tbAddress.Text, Int32.Parse(tbYearBulit.Text),
                    tbBuilder.Text, Int32.Parse(tbSquareFootage.Text), cbGarage.Checked,
                    Decimal.Parse(tbRent.Text));
                this.Close();
            }

        }

        public SingleFamily GetSingle()
        {
            this.ShowDialog();
            return single;
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(tbAddress) &&
                Validator.IsPresent(tbBuilder) &&
                Validator.IsPresent(tbRent) &&
                Validator.IsPresent(tbSquareFootage) &&
                Validator.IsPresent(tbYearBulit) &&
                Validator.IsInt32(tbYearBulit) &&
                Validator.IsInt32(tbSquareFootage) &&
                Validator.IsDecimal(tbRent);
        }
    }
}
