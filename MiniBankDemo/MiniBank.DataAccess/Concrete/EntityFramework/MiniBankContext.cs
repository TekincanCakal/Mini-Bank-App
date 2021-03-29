using MiniBank.Entities.Concrete;
using System.Data.Entity;

namespace MiniBank.DataAccess.Concrete.EntityFramework
{
    public class MiniBankContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}
