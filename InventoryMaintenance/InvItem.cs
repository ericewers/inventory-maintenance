using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItem
    {
        // Fields
        private int itemNo;
        private string description;
        private decimal price;

        // Blank Constructor
        public InvItem()
        {
        }

        // Custom Constructor
        public InvItem(int itemNo, string description, decimal price)
        {
            this.ItemNo = itemNo;
            this.Description = description;
            this.Price = price;
        }

        // ItemNo Property
        public int ItemNo
        {
            get
            {
                return itemNo;
            }
            set
            {
                itemNo = value;
            }
        }

        // Description Property
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        // Price Property
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        // GetDisplayText Method
        public string GetDisplayText() => itemNo + "    " + description + " (" + price.ToString("C") + ")"; // Format price variable to Currency
    }
}
