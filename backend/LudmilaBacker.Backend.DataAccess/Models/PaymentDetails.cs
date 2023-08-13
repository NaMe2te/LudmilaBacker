using LudmilaBacker.Backend.DataAccess.CodeForms.Enums;

namespace LudmilaBacker.Backend.DataAccess.Models;

public class PaymentDetails
{
    public PaymentDetails(decimal totalAmount)
    {
        PaymentStatus = PaymentStatus.NotPaid;
        TotalAmount = totalAmount;
    }
    
    public Guid Id { get; init; }
    public decimal TotalAmount { get; init; }
    
    public PaymentStatus PaymentStatus { get; private set; }
    public PaymentMethod PaymentMethod { get; init; }
}