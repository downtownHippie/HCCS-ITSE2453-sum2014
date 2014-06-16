using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new int[] {24,18,21,20,19,24,18,21,20,19,24,18,21,19,24,18,23,21,19,24,18,21,19,24,18,21,30,32,24,26};

            BagOfCoins bag = new BagOfCoins();
            bag.SortCoinTally(coins);
            Console.Write(bag.ToString());
            Console.ReadLine();
        }
    }
}
