using LudmilaBacker.Backend.DataAccess.CodeForms.Enums;

namespace LudmilaBacker.Backend.DataAccess.Models;

public class Account
{
    public Account(string name, string phone, string password, Cart cart)
    {
        Name = name;
        Phone = phone;
        Password = password;
        Cart = cart;
        TotalExpenditure = 0;
        Orders = new List<Order>();
    }

    public Guid Id { get; init; }
    public string Name { get; private set; }
    public string Phone { get; init; }
    public string Password { get; private set; }
    public decimal TotalExpenditure { get; private set; }
    
    public Role Role { get; private set; }
    public virtual Cart Cart { get; init; }
    public virtual ICollection<Order> Orders { get; init; }
}