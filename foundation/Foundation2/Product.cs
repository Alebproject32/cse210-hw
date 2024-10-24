public class Product
{
    public string Name { get; private set; }
    public string ProductID { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, string productID, decimal price, int quantity)
    {
        Name = name;
        ProductID = productID;
        Price = price;
        Quantity = quantity;
    }

    public decimal TotalCost()
    {
        return Price * Quantity;
    }
}