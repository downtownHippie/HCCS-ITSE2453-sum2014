using System;
using System.Collections;
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
            createFromClick<int>();
        }

        private void buttonCreateDoubles_Click(object sender, EventArgs e)
        {
            createFromClick<double>();
        }

        private void buttonCreateChars_Click(object sender, EventArgs e)
        {
            createFromClick<char>();
        }

        private void buttonCreateStrings_Click(object sender, EventArgs e)
        {
            createFromClick<string>();
        }

        private void createFromClick<T>()
            where T : IComparable
        {
            searchList = searchList.createValues<T>();
            setTextBoxList(searchList.GetInnerList());
            buttonSearch.Enabled = true;
        }

        private void setTextBoxList(IList list)
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
                labelValueFound.Text = "Please enter a search key";
                return;
            }
            labelValueFound.Text = searchList.Search(textBoxSearchTerm.Text);
        }

    }
}
