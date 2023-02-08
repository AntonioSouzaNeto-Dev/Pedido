using Exe_3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        public void AddItems(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItems(OrderItem item)
        {
            Items.Remove(item);
        }
       
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
    }
}
