using System;
using System.Windows.Forms;
using PropertyTypes;

namespace RentalPropertyManager
{
    public partial class frmManager : Form
    {
        TheProperties theproperties = new TheProperties();

        public frmManager()
        {
            InitializeComponent();
            theproperties.Changed += new TheProperties.PropertiesHandler(listChange);
        }

        private void listChange(TheProperties theProperties)
        {
            FillListBox();
        }

        private void FillListBox()
        {
            listBoxOfProperties.Items.Clear();
            for (int i = 0; i < theproperties.Count; i++)
            {
                listBoxOfProperties.Items.Add(theproperties[i].GetDisplayText());
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddSingle_Click(object sender, EventArgs e)
        {
            SingleFamily single = new frmAddOrEditSingle().GetSingle();
            if (single != null)
                theproperties += single;
        }

        private void buttonAddMulti_Click(object sender, EventArgs e)
        {
            MultiUnit multi = new frmAddOrEditMulti().GetMulti();
            if (multi != null)
                theproperties += multi;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if ((listBoxOfProperties.SelectedIndex != -1) &&
                    (MessageBox.Show("Are you sure you want to delete "
                    + theproperties[listBoxOfProperties.SelectedIndex].Address + "?",
                    "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes))
                theproperties -= theproperties[listBoxOfProperties.SelectedIndex];
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            if (listBoxOfProperties.SelectedIndex != -1)
                new frmDetails(theproperties[listBoxOfProperties.SelectedIndex]).Show();
        }

        private void buttonEditProperty_Click(object sender, EventArgs e)
        {
            if (listBoxOfProperties.SelectedIndex != -1)
            {
                if (theproperties[listBoxOfProperties.SelectedIndex].GetType() == typeof(SingleFamily))
                {
                    theproperties[listBoxOfProperties.SelectedIndex] =
                        new frmAddOrEditSingle((SingleFamily)theproperties[listBoxOfProperties.SelectedIndex]).GetSingle();
                }
                else if (theproperties[listBoxOfProperties.SelectedIndex].GetType() == typeof(MultiUnit))
                {
                    theproperties[listBoxOfProperties.SelectedIndex] =
                        new frmAddOrEditMulti((MultiUnit)theproperties[listBoxOfProperties.SelectedIndex]).GetMulti();
                }
                else
                {
                    MessageBox.Show("This is an invalid type of property: " + theproperties[listBoxOfProperties.SelectedIndex].GetType(), "Error", MessageBoxButtons.OK); 
                }
            }
        }
    }
}
