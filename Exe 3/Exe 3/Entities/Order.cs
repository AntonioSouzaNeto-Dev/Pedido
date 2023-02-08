using Exe_3.Entities.Enums;
using System.Text;
using System.Globalization;


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
        public Order(DateTime moment, OrderStatus status, Client client)
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Client: " + Client.Name);
            sb.Append(" " + Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.AppendLine(" - " + Client.Email);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                sb.Append(item.Product.Name);
                sb.Append(", " + item.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: " + item.Quantity);
                sb.AppendLine(", Subtotal: $" + item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
