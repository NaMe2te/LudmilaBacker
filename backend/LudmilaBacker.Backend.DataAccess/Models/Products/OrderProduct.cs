namespace LudmilaBacker.Backend.DataAccess.Models.Products;

public class OrderProduct
{
    public OrderProduct(float weight, decimal price, Product product, Order order)
    {
        Weight = weight;
        Price = price;
        Product = product;
        Order = order;
    }

    public Guid Id { get; init; }
    public float Weight { get; init; }
    public decimal Price { get; init; }
    public Product Product { get; init; }
    public Order Order { get; init; }
}