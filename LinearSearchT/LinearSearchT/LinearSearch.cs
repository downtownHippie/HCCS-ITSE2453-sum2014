using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace LinearSearchT
{
    public partial class LinearSearch : Form
    {
        List<int> intListValues;
        List<double> doubleListValues;
        Type listType;

        public LinearSearch()
        {
            InitializeComponent();
        }

        private void buttonCreateIntegers_Click(object sender, EventArgs e)
        {
            this.intListValues = Program.createIntegers();
            setTextBoxList(intListValues);
            listType = typeof(int);
            buttonSearch.Enabled = true;
        }

        private void buttonCreateDoubles_Click(object sender, EventArgs e)
        {
            this.doubleListValues = Program.createDoubles();
            setTextBoxList(doubleListValues);
            listType = typeof(double);
            buttonSearch.Enabled = true;
        }

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

        //private void setTextBoxList()
        //{
        //    textBoxList.Text = String.Empty;
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendFormat("{0}{1}", "Index".PadRight(10), "Value".PadRight(10));
        //    sb.Append(Environment.NewLine);
        //    for (int i = 0; i < intListValues.Count; i++)
        //    {
        //        sb.AppendFormat("{0}{1}", i.ToString().PadRight(10), intListValues[i].ToString().PadRight(10));
        //        // don't add newline after last element
        //        if (i < intListValues.Count - 1)
        //            sb.Append(Environment.NewLine);
        //    }
        //    textBoxList.Text = sb.ToString();
        //}


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxSearchTerm.Text))
            {
                labelValueFound.Text = "Must enter search key";
                return;
            }
            if (listType == typeof(int))
            {
                int key;
                if (!Int32.TryParse(textBoxSearchTerm.Text, out key))
                {
                    labelValueFound.Text = "Search key must be an integer value";
                    return;
                }
                int index = Program.Search(key, intListValues);
                setLabelValueFound(index, key);
            }
            else if (listType == typeof(double))
            {
                double key;
                if (!Double.TryParse(textBoxSearchTerm.Text, out key))
                {
                    labelValueFound.Text = "Search key must be a double value";
                    return;
                }
                int index = Program.Search(key, doubleListValues);
                setLabelValueFound(index, key);
            }
            else
            {
                // something really wrong happened!
                labelValueFound.Text = "Something really wrong happened";
                return;
            }
        }

        void setLabelValueFound<T>(int index, T key)
        {
            if (index == -1)
            {
                labelValueFound.Text = "Value: " + key + " not found in list";
            }
            else
            {
                labelValueFound.Text = "Value: " + key + " found at index: " + index;
            }
        }
    }
}
