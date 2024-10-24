using System;

namespace FoundationNumerTwo
{
    public class Program
{
    public static void Main()
    {
        var address1 = new Address("123 Main St", "New York", "NY", "USA");
        var customer1 = new Customer("John Doe", address1);

        var address2 = new Address("456 Elm St", "London", "LDN", "UK");
        var customer2 = new Customer("Jane Smith", address2);

        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "B456", 49.99m, 2));

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "C789", 799.99m, 1));
        order2.AddProduct(new Product("Headphones", "D012", 149.99m, 1));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine($"Total Cost: {order.TotalCost():C}");
            Console.WriteLine();
        }
    }
}

}