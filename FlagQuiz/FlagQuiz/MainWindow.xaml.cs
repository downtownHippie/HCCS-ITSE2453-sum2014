using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlagQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<KeyValuePair<string, string>> flags = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string> ( "Australia", "Images/australia.png"),
                new KeyValuePair<string, string> ( "Brazil", "Images/brazil.png"),
                new KeyValuePair<string, string> ( "China", "Images/china.png"),
                new KeyValuePair<string, string> ( "Italy", "Images/italy.png"),
                new KeyValuePair<string, string> ( "Russia", "Images/russia.png"),
                new KeyValuePair<string, string> ( "South Africa", "Images/southafrica.png"),
                new KeyValuePair<string, string> ( "Spain", "Images/spain.png"),
                new KeyValuePair<string, string> ( "United States", "Images/unitedstates.png")
            };

        private string answer;
        private Random r = new Random();

        public MainWindow()
        {
            InitializeComponent();

            flags.ForEach(f => cbCountry.Items.Add(f.Key));

            setNextFlag();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (cbCountry.SelectedIndex == -1)
                MessageBox.Show("Please select the country identified by the flag");
            else
                if (cbCountry.SelectedValue.Equals(answer))
                {
                    changeScore(true);
                    btnSubmit.IsEnabled = false;
                    btnNextFlag.IsEnabled = true;
                    cbCountry.IsEnabled = false;
                }
                else
                {
                    changeScore(false);
                    MessageBox.Show("Make another selection");
                    btnSubmit.IsEnabled = false;
                }
        }

        private void changeScore(bool wasIRight)
        {
            string[] score = tbScore.Text.Split('/');
            int tries = Int32.Parse(score[1]);
            int right = Int32.Parse(score[0]);
            if (wasIRight)
            {
                tbSomeWords.Text = "Correct";
                right++;
            }
            else
                tbSomeWords.Text = "Incorrect";
            tries++;
            tbScore.Text = right + "/" + tries;
        }

        private void btnNextFlag_Click(object sender, RoutedEventArgs e)
        {
            setNextFlag();
            cbCountry.IsEnabled = true;
            btnSubmit.IsEnabled = true;
            btnNextFlag.IsEnabled = false;
        }

        private void setNextFlag()
        {
            if (flags.Count == 0)
            {
                string[] score = tbScore.Text.Split('/');
                int tries = Int32.Parse(score[1]);
                int right = Int32.Parse(score[0]);
                MessageBox.Show("Congratulations your score is " + right + " correct in " + tries + " tries");
                this.Close();
            }
            else
            {
                int i = r.Next(0, flags.Count);
                answer = flags[i].Key;
                imgFlag.Source = new BitmapImage(new Uri(flags[i].Value, UriKind.Relative));
                flags.RemoveAt(i);
            }
        }

        private void cbCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnSubmit.IsEnabled = true;
            btnNextFlag.IsEnabled = false;
        }
    }
}
