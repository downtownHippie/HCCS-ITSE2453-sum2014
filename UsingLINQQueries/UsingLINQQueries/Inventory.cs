using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLINQQueries
{
    class Inventory
    {
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public int QtyOnHand { get; set; }
        public decimal UnitPrice { get; set; }

        public Inventory()
        {
        }

        public Inventory(string itemNo, string description, int qtyOnHand, decimal unitPrice)
        {
            ItemNo = itemNo;
            Description = description;
            QtyOnHand = qtyOnHand;
            UnitPrice = unitPrice;
        }

        public override string ToString()
        {
            return ItemNo + " " + Description + " " + QtyOnHand + " " + UnitPrice;
        }
    }
}
