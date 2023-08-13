using LudmilaBacker.Backend.DataAccess.Models.Products;

namespace LudmilaBacker.Backend.DataAccess.Models;

public class Order
{
    public Order(Account account, decimal totalAmount, string? address, ICollection<OrderProduct> productsInOrder)
    {
        Date = DateTime.Now;
        PaymentDetails = new PaymentDetails(totalAmount);
        Address = address;
        OrderProducts = productsInOrder;
    }

    public Guid Id { get; init; }
    public DateTime Date { get; init; }
    public PaymentDetails PaymentDetails { get; init; }
    public string? Address { get; init; }
    
    public virtual ICollection<OrderProduct> OrderProducts { get; init; }
}