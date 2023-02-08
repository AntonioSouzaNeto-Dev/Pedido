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
        public Product Product { get; set; }
        public OrderItem() { }
        public OrderItem(int quantity, double price, Product produto)
        {
            Quantity = quantity;
            Price = price;
            Product = produto;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }

    
}
