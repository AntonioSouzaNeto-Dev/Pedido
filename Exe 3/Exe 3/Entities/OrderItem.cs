using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_3.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal(int quantity, double price)
        {
            return quantity * price;
        }
    }

    
}
