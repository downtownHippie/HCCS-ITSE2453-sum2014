using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LinearSearchT
{
    public partial class LinearSearch : Form
    {
        SearchList searchList = new SearchList();

        public LinearSearch()
        {
            InitializeComponent();
        }

        private void buttonCreateIntegers_Click(object sender, EventArgs e)
        {
            //createFromClick(typeof(int);
            searchList = searchList.createValues<int>();
            setTextBoxList(searchList.GetInnerList<int>());
            buttonSearch.Enabled = true;
        }

        private void buttonCreateDoubles_Click(object sender, EventArgs e)
        {
            //createFromClick(typeof(double));
            searchList = searchList.createValues<double>();
            setTextBoxList(searchList.GetInnerList<double>());
            buttonSearch.Enabled = true;
        }

        private void buttonCreateChars_Click(object sender, EventArgs e)
        {
            //createFromClick(typeof(char));
            searchList = searchList.createValues<char>();
            setTextBoxList(searchList.GetInnerList<char>());
            buttonSearch.Enabled = true;
        }

        private void buttonCreateStrings_Click(object sender, EventArgs e)
        {
            //createFromClick(typeof(string));
            searchList = searchList.createValues<string>();
            setTextBoxList(searchList.GetInnerList<string>());
            buttonSearch.Enabled = true;
        }

        //private void createFromClick(Type type)
        //{
        //    searchList = searchList.createValues<type>();
        //    setTextBoxList(searchList.GetInnerList<type>());
        //    buttonSearch.Enabled = true;
        //}

        private void setTextBoxList<T>(List<T> list)
        {
            textBoxList.Text = String.Empty;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}", "Index".PadRight(10), "Value".PadRight(10));
            sb.Append(Environment.NewLine);
            for (int i = 0; i < list.Count; i++)
            {
                sb.AppendFormat("{0}{1}", i.ToString().PadRight(10), list[i].ToString().PadRight(10));
                // don't add newline after last element
                if (i < list.Count - 1)
                    sb.Append(Environment.NewLine);
            }
            textBoxList.Text = sb.ToString();
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxSearchTerm.Text))
            {
                labelValueFound.Text = "Must enter search key";
                return;
            }
            labelValueFound.Text = searchList.SearchButton(textBoxSearchTerm.Text);
        }

    }
}
