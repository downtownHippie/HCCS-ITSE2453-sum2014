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

        public static string ConvertToPigLatin(this string sentence)
        {
            string[] words = sentence.Split();
            StringBuilder pigLatin = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                StringBuilder newWord = new StringBuilder();
                for (int j = 1; j < words[i].Length; j++)
                {
                    newWord.Append(words[i][j]);
                }
                if (Char.IsUpper(words[i][0]))
                {
                    newWord[0] = Char.ToUpper(newWord[0]);
                    newWord.Append(Char.ToLower(words[i][0]));
                }
                else
                    newWord.Append(words[i][0]);
                newWord.Append("ay");
                pigLatin.Append(newWord);
                if (i <= words.Length - 1)
                    pigLatin.Append(" ");
            }
            return pigLatin.ToString();
        }
    }
}
