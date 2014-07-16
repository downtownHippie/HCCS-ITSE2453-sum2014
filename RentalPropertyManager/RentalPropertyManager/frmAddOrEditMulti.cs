using System;
using System.Windows.Forms;
using PropertyTypes;

namespace RentalPropertyManager
{
    public partial class frmAddOrEditMulti : Form
    {
        private MultiUnit multi = null;

        public frmAddOrEditMulti()
        {
            InitializeComponent();
        }

        public frmAddOrEditMulti(MultiUnit multi)
        {
            InitializeComponent();
            this.multi = multi;
            tbAddress.Text = this.multi.Address;
            tbBuilder.Text = this.multi.Builder;
            tbNumUnits.Text = this.multi.NumUnits.ToString();
            tbPricePer.Text = this.multi.PricePerUnit.ToString();
            tbYearBulit.Text = this.multi.YearBuilt.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                multi = new MultiUnit(tbAddress.Text, Int32.Parse(tbYearBulit.Text),
                    tbBuilder.Text, Int32.Parse(tbNumUnits.Text), Decimal.Parse(tbPricePer.Text));
                this.Close();
            }
        }

        public MultiUnit GetMulti()
        {
            this.ShowDialog();
            return multi;
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(tbAddress) &&
                Validator.IsPresent(tbBuilder) &&
                Validator.IsPresent(tbNumUnits) &&
                Validator.IsPresent(tbPricePer) &&
                Validator.IsPresent(tbYearBulit) &&
                Validator.IsInt32(tbYearBulit) &&
                Validator.IsInt32(tbNumUnits) &&
                Validator.IsDecimal(tbPricePer);
        }
    }
}
