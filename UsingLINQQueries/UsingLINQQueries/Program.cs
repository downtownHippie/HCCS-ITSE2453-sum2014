using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLINQQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory[] inventory = new Inventory[] 
                {
                    new Inventory("A123", "Jig saw", 15, 12.00M),
                    new Inventory("B23", "Wrench", 20, 11.00M),
                    new Inventory("C112", "Hammer", 10, 8.00M),
                    new Inventory("B135", "Power saw", 8, 79.00M),
                    new Inventory("C238", "Screwdriver", 30, 9.50M),
                    new Inventory("A890", "Lawn mower", 6, 95.00M),
                    new Inventory("C290", "Electric sander", 12, 55.00M),
                    new Inventory("C100", "Sledge Hammer", 9, 30.50M),
                };

            var invSortedByDescription = from i in inventory
                                      orderby i.Description
                                      select i;
            Console.WriteLine("inventory sorted by description");
            foreach (var item in invSortedByDescription)
            {
                Console.WriteLine("    " + item);
            }

            var descAndPriceSortedByPrice = from i in inventory
                                           orderby i.UnitPrice
                                           select new { i.Description, i.UnitPrice };
            Console.WriteLine("\ndescription and unitPrice, sorted by unitPrice");
            foreach (var item in descAndPriceSortedByPrice)
            {
                Console.WriteLine("    " + item);
            }

            var descAndTotal = from i in inventory
                               let total = i.QtyOnHand * i.UnitPrice
                               orderby total
                               select new { i.Description, total };
            Console.WriteLine("\ndescription and total, sorted by total");
            foreach (var item in descAndTotal)
            {
                Console.WriteLine("    " + item);
            }

            var invFrom30To90ByunitPriceDesc = from i in inventory
                                               where i.UnitPrice >= 30M && i.UnitPrice <= 90M
                                               orderby i.UnitPrice descending
                                               select i;
            Console.WriteLine("\ninventory with unitPrice ranging from $30 to $90, sorted by unitPrice, descending");
            foreach (var item in invFrom30To90ByunitPriceDesc)
            {
                Console.WriteLine("    " + item);
            }

            var invDescUPPERByDesc = from i in inventory
                                     let descUpper = i.Description.ToUpper()
                                     orderby descUpper
                                     select new Inventory(i.ItemNo, descUpper, i.QtyOnHand, i.UnitPrice);
            Console.WriteLine("\ninventory with Description converted to upper case, sorted by description");
            foreach (var item in invDescUPPERByDesc)
            {
                Console.WriteLine("    " + item);
            }

            Console.ReadLine();
        }
    }
}

