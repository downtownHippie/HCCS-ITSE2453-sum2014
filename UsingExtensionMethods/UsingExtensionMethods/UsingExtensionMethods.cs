using System;
using System.Text;

namespace UsingExtensionMethods
{
    public static class UsingExtensionMethods
    {
        public static int SumOfDigits(this int number)
        {
            int[] digits = Array.ConvertAll(number.ToString().ToCharArray(),
                element => Int32.Parse(element.ToString()));
            int sum = 0;
            foreach (int i in digits)
            {
                sum += i;
            }
            return sum;
        }

        public static string ConvertToPigLatin(this string word)
        {
            StringBuilder pigLatin = new StringBuilder();
            for (int i = 1; i < word.Length; i++)
            {
                pigLatin.Append(word[i]);
            }
            pigLatin.Append(word[0]);
            pigLatin.Append("ay");
            return pigLatin.ToString();
        }
    }
}
