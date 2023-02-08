using Exe_3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_3.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, List<OrderItem> orderItems)
        {
            Moment = moment;
            Status = status;
            this.orderItems = orderItems;
        }

        public void AddItem(Product produtos)
        {
           
        }
    }
}
