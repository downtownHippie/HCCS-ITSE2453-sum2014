using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LinearSearchT
{
    public class SearchList
    {
        private IList innerList;
        private Type type;

        public IList GetInnerList()
        {
            return innerList;
        }

        public void SetInnerList<T>(IList values)
        {
            innerList = values;
            type = typeof(T).GenericTypeArguments[0];
        }

        public string Search(string searchvalue)
        {
            try
            {
                IComparable key = (IComparable)Convert.ChangeType(searchvalue, type);
                int index = innerList.Search(key);
                if (index == -1)
                    return "Value: " + key + " not found in list";
                else
                    return "Value: " + key + " found at index: " + index;
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

        public SearchList createValues<T>()
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
                    char[] chars = new char[r.Next(1, 11)];
                    for (int d = 0; d < chars.Length; d++)
                        chars[d] = (char)r.Next(33, 127);
                    list.Add((T)Convert.ChangeType(new string(chars), typeof(T)));
                }
                else
                {
                    // should never get here
                    string message = "creation of " + typeof(T).Name + " has not been written";
                    throw new InvalidOperationException(message);
                }
            }
            SetInnerList<List<T>>(list);
            return this;
        }
    }

    // yeah, most of the time I would say that each class deserves it's own file
    // but in my opinion that's not an absolute rule...
    public static class SearchListHelper
    {
        public static int Search<T>(this IList aList, T key)
            where T : IComparable
        {
            for (int i = 0; i < aList.Count; i++)
                if (aList[i].Equals(key))
                    return i;
            return -1;
        }
    }
}
