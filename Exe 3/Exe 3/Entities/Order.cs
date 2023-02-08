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

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }

        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, List<OrderItem> items, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItems(OrderItem items)
        {
            Items.Add(items);
        }
        public void removeItems(OrderItem items)
        {
            Items.Remove(items);
        }
    }
}
