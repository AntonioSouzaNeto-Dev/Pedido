using Exe_3.Entities;
using Exe_3.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string? name = Console.ReadLine();
Console.Write("Email: ");
string? email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data: ");
Console.Write("Status: " );
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.Write("How many items to this order? ");
int quantItems = Convert.ToInt32(Console.ReadLine());

Client client = new Client(name, email, birthDate);
Order order = new Order(DateTime.Now, status , client);

for (int i = 0; i < quantItems; i++)
{
    Console.WriteLine("Enter #{0} item data: ", i + 1);
    Console.Write("Product name: ");
    string? productName = Console.ReadLine();
    Console.Write("Product price: ");
    double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quantity = Convert.ToInt32(Console.ReadLine());
    Product product = new Product(productName, price);
    OrderItem items = new OrderItem(quantity, price, product);
    order.AddItems(items);    
}

Console.WriteLine();
Console.WriteLine(order);
