using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace CashRegister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal total = 0m;
        private decimal taxRate = 0.1m;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            tbAmount.Clear();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbAmount.Clear();
            tbSubtotal.Clear();
            tbTax.Clear();
            tbTotal.Clear();
            total = 0m;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbAmount.Text))
            {
                total += Decimal.Parse(tbAmount.Text);
                tbAmount.Clear();
                tbSubtotal.Text = total.ToString("#.00");
            }
        }

        private void btnTotal_Click(object sender, RoutedEventArgs e)
        {
            tbTax.Text = (total * taxRate).ToString("#.00");
            tbTotal.Text = (total + (total * taxRate)).ToString("0.##");
            tbSubtotal.Text = total.ToString("#.00");
            total = 0m;
        }

        private void btNumPad_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder(tbAmount.Text);
            sb.Append(((Button)sender).Tag);
            tbAmount.Text = sb.ToString();
        }
    }
}
