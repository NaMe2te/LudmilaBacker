namespace LudmilaBacker.Backend.DataAccess.Models.Products;

public class Product
{
    public Product(string name, string description, decimal priceForKg)
    {
        Name = name;
        Description = description;
        PriceForKg = priceForKg;
    }

    public Guid Id { get; init; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal PriceForKg { get; private set; }
}