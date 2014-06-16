using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinSort
{
    public class BagOfCoins
    {
        const int QUARTER = 24;
        const int DIME = 18;
        const int NICKEL = 21;
        const int PENNY = 19;

        private int quarters;
        private int dimes;
        private int nickels;
        private int pennies;
        private int foreign;

        public BagOfCoins()
        {
            this.quarters = 0;
            this.dimes = 0;
            this.nickels = 0;
            this.pennies = 0;
            this.foreign = 0;
        }

        public void SortCoinTally(int[] coins)
        {
            for (int i = 0; i < coins.Length; i++)
            {
                switch (coins[i])
                {
                    case QUARTER:
                        this.quarters++;
                        break;
                    case DIME:
                        this.dimes++;
                        break;
                    case NICKEL:
                        this.nickels++;
                        break;
                    case PENNY:
                        this.pennies++;
                        break;
                    default:
                        this.foreign++;
                        break;
                }
            }
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            total += this.quarters * 0.25M;
            total += this.dimes * 0.10M;
            total += this.nickels * 0.05M;
            total += this.pennies * 0.01M;
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Quarters: {0}\n", this.quarters);
            sb.AppendFormat("Dimes: {0}\n", this.dimes);
            sb.AppendFormat("Nickels: {0}\n", this.nickels);
            sb.AppendFormat("Pennies: {0}\n", this.pennies);
            sb.AppendFormat("Foreign Coins: {0}\n", this.foreign);
            sb.AppendFormat("Total US cash: {0:C}\n", CalculateTotal());

            return sb.ToString();
        }
    }
}
