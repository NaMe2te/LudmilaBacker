using LudmilaBacker.Backend.DataAccess.Models.Products;

namespace LudmilaBacker.Backend.DataAccess.Models;

public class Cart
{
    public Cart()
    {
        CartProducts = new List<CartProduct>();
        Price = 0;
    }

    public Guid Id { get; init; }
    public decimal Price { get; private set; }
    public virtual ICollection<CartProduct> CartProducts { get; private set; }
}