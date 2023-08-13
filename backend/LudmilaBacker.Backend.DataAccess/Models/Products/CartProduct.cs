namespace LudmilaBacker.Backend.DataAccess.Models.Products;

public class CartProduct
{
    public CartProduct(float weight, Product product, Cart cart)
    {
        Weight = weight;
        Product = product;
        Cart = cart;
        Price = (decimal) Weight * Product.PriceForKg;
    }

    public Guid Id { get; init; }
    public float Weight { get; init; }
    public decimal Price { get; init; }
    public Product Product { get; init; }
    public Cart Cart { get; init; }
}