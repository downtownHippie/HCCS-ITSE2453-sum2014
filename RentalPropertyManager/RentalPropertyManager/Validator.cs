using System;
using System.Windows.Forms;

namespace RentalPropertyManager
{
    public static class Validator
    {
        public static string Title
        {
            get { return "Entry Error"; }
        }

        public static bool IsPresent(TextBox textbox)
        {
            if (String.IsNullOrWhiteSpace(textbox.Text))
            {
                MessageBox.Show(textbox.Tag + " is a required field.", Title);
                textbox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be a decimal number.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }
    }
}
