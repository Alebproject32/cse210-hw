public class Order
{
    private List<Product> products;
    public Customer Customer { get; private set; }

    public Order(Customer customer)
    {
        Customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }
        total += Customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.Name} (ID: {product.ProductID})\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{Customer.Name}\n{Customer.Address.FullAddress()}";
    }
}