using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LinearSearchT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LinearSearch());
        }

        public static int Search<T>(T key, List<T> alist) where T : IComparable<T>
        {
            //return alist.FindIndex(x => x.Equals(key));
            for (int i = 0; i < alist.Count; i++)
            {
                if (alist[i].Equals(key))
                    return i;
            }
            return -1;
        }

        public static List<int> createIntegers()
        {
            List<int> list = new List<int>();
            Random r = new Random();
            int n = r.Next(10,51);
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(1, 5001));
            }
            return list;
        }

        public static List<double> createDoubles()
        {
            List<double> list = new List<double>();
            Random r = new Random();
            int n = r.Next(10, 51);
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(1,2501) * 2.5);
            }
            return list;
        }
    }
}
