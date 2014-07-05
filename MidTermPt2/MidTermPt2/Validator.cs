using System;
using System.Windows.Forms;

namespace MidTermPt2
{
    public static class Validator
    {
        private static string title = "Entry Error";

        public static bool IsPresent(TextBox textBox)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(textBox.Tag + " can not be white space or empty.", title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", title);
                textBox.Focus();
                return false;
            }
        }
    }
}
