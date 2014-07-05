using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// thanks to:
// http://www.rhyous.com/2010/06/15/regular-expressions-in-cincluding-a-new-comprehensive-email-pattern/
// with some mods according to
// http://tools.ietf.org/html/rfc3696

namespace MidTermPt1
{
    public static class Validator
    {
        private static string title = "Entry Error";

        public static bool IsPresent(TextBox textbox)
        {
            if (String.IsNullOrWhiteSpace(textbox.Text))
            {
                MessageBox.Show(textbox.Tag + " cannot be empty or whitespace.", title);
                textbox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(TextBox textBox)
        {
            Regex regex = new Regex(@"^(([\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*)|("".+""))@((([\-\w]+\.)+[a-zA-Z]{2,4})|((([01]?[0-9]{1,2}|2[0-4][0-9]|25[0-5]).){3}[01]?[0-9]{1,2}|2[0-4][0-9]|25[0-5]))\z");
            if (!regex.IsMatch(textBox.Text))
            {
                MessageBox.Show("Invalid email address", title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsValidPhoneNumber(TextBox textBox)
        {
            Regex regex = new Regex(@"^(\([\d]{3}\)[\d]{3}\-[\d]{4})|([\d]{3}\-[\d]{3}\-[\d]{4})\z");
            if (!regex.IsMatch(textBox.Text))
            {
                MessageBox.Show("Phone number must be of the form: (xxx)xxx-xxxx or xxx-xxx-xxxx", title);
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
