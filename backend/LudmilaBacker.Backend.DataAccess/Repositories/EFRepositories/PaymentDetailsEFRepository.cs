using LudmilaBacker.Backend.DataAccess.DBContexts;
using LudmilaBacker.Backend.DataAccess.Models;

namespace LudmilaBacker.Backend.DataAccess.Repositories.EFRepositories;

public class PaymentDetailsEFRepository : BaseRepository<PaymentDetails>
{
    public PaymentDetailsEFRepository(DatabaseContext databaseContext) 
        : base(databaseContext)
    {
    }
}