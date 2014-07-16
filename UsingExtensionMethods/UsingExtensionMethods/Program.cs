using System;

namespace UsingExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer, a word, or \"Quit\" to exit:");
            string input = Console.ReadLine();
            while (input != "Quit")
            {
                try
                {
                    Console.WriteLine("The sum of the digits is: {0}", Convert.ToInt32(input).SumOfDigits());
                }
                catch (Exception)
                {
                    if (!String.IsNullOrWhiteSpace(input))
                        Console.WriteLine("The PigLatin translation is:\n    {0}", input.ConvertToPigLatin());
                }
                Console.WriteLine("Enter an integer, a word, or \"Quit\" to exit:");
                input = Console.ReadLine();
            }
            Console.WriteLine("Press <enter> to continue");
            Console.ReadLine();
        }
    }
}
