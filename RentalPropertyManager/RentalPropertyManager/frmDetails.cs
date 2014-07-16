using System;
using System.Windows.Forms;
using PropertyTypes;

namespace RentalPropertyManager
{
    public partial class frmDetails : Form
    {
        private Housing house;

        public frmDetails(Housing house)
        {
            InitializeComponent();
            this.house = house;
            lblAddress.Text = house.Address;
            lblBuilder.Text = "Built by: " + house.Builder;
            lblYearBuilt.Text = "Built In: " + house.YearBuilt;
            lblYearlyIncome.Text = "Yearly Income: " + house.yearlyRentalIncome().ToString("c");
            if (house.GetType() == typeof(SingleFamily))
            {
                SingleFamily unit = (SingleFamily)house;
                lblSize.Text = unit.SquareFeet + " square feet";
                lblRent.Text = "Monthly Rent: " + unit.Rent.ToString("c");
                lblGarage.Text = unit.HasGarage ? "Garage" : "No garage";
            }
            else if (house.GetType() == typeof(MultiUnit))
            {
                MultiUnit unit = (MultiUnit)house;
                lblSize.Text = unit.NumUnits + " units";
                lblRent.Text = unit.PricePerUnit.ToString("c") + " per unit";
                lblGarage.Text = String.Empty;
            }
            else
            {
                this.Close();
                MessageBox.Show("This is an invalid property Type: " + house.GetType(), "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
