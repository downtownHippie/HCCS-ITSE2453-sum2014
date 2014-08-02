using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FlagQuiz
{
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
                    raiseScore(true);
                    btnSubmit.IsEnabled = false;
                    btnNextFlag.IsEnabled = true;
                    cbCountry.IsEnabled = false;
                }
                else
                {
                    raiseScore(false);
                    btnSubmit.IsEnabled = false;
                    MessageBox.Show("Make another selection");
                }
        }

        private void raiseScore(bool wasIRight)
        {
            string[] score = tbScore.Text.Split('/');
            int right = Int32.Parse(score[0]);
            int tries = Int32.Parse(score[1]) + 1;
            tbResult.Text = wasIRight ? "Correct" : "Incorrect";
            right = wasIRight ? right + 1 : right;
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
                int right = Int32.Parse(score[0]);
                int tries = Int32.Parse(score[1]);
                MessageBox.Show("Congratulations your score is " + right + " correct in " + tries + " tries.");
                this.Close();
            }
            else
            {
                int i = r.Next(0, flags.Count);
                answer = flags[i].Key;
                //ImageSourceConverter converter = new ImageSourceConverter();
                //ImageSource source = (ImageSource)converter.ConvertFromString(flags[i].Value);
                //imgFlag.Source = source;
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
