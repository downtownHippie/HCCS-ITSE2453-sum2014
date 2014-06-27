using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LinearSearchT
{
    public class SearchList
    {
        IList innerList;
        Type type;

        public List<T> GetInnerList<T>()
        {
            return (List<T>)innerList;
        }

        public void SetInnerList<T>(IList values)
        {
            innerList = values;
            type = typeof(T).GenericTypeArguments[0];
        }

        public string SearchButton(string searchvalue)
        {
            try
            {
                IComparable key = (IComparable)Convert.ChangeType(searchvalue, type);
                int index = innerList.Search(key);
                return setLabelValueFound(index, key);
            }
            catch (Exception)
            {
                StringBuilder message = new StringBuilder("Not a valid value. Please enter a");
                if (Regex.IsMatch(new string(type.Name[0], 1), @"[aeiouAEIOU]"))
                {
                    message.Append("n");
                }
                message.AppendFormat(" {0}", type.Name);
                return message.ToString();
            }

        }

        private string setLabelValueFound<T>(int index, T key)
        {
            if (index == -1)
                return "Value: " + key + " not found in list";
            else
                return "Value: " + key + " found at index: " + index;
        }
    }

    // yeah, most of the time I would say that each class deserves it's own file
    // but in my opinion that's not an absolute rule...
    public static class SearchListHelper
    {
        public static SearchList createValues<T>(this SearchList sl)
           where T : IComparable
        {
            List<T> list = new List<T>();
            Random r = new Random();
            int n = r.Next(10, 51);

            for (int i = 0; i < n; i++)
            {
                if (typeof(T) == typeof(double))
                    list.Add((T)Convert.ChangeType((r.Next(1, 2501) * 2.5), typeof(T)));
                else if (typeof(T) == typeof(int))
                    list.Add((T)Convert.ChangeType(r.Next(1, 5001), typeof(T)));
                else if (typeof(T) == typeof(char))
                    list.Add((T)Convert.ChangeType(r.Next(33, 127), typeof(T)));
                else if (typeof(T) == typeof(string))
                {
                    int x = r.Next(1, 11);
                    char[] chars = new char[x];
                    for (int d = 0; d < x; d++)
                        chars[d] = (char)r.Next(33, 127);
                    list.Add((T)Convert.ChangeType(new string(chars), typeof(T)));
                }
                else
                {
                    // I hope we never get here!!!
                    string message = "how'd you do that?, this is an invalid type {0} " + typeof(T).Name;
                    throw new InvalidOperationException(message);
                }
            }
            sl.SetInnerList<List<T>>(list);
            return sl;
        }
        
        public static int Search<T>(this IList lst, T key)
            where T : IComparable
        {
            for (int i = 0; i < lst.Count; i++)
                if (lst[i].Equals(key))
                    return i;
            return -1;
        }
    }
}
