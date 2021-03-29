using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MiniBank.Entities.Abstract;

namespace MiniBank.Entities.Concrete
{
    [Table("BankAccounts")]
    public class BankAccount : IEntity
    {
        [Key]
        public string BankAccountNumber { get; set; }
        public int CustomerId { get; set; }
        [Index(IsUnique = true)]
        public string Iban { get; set; }
        public decimal Money { get; set; }
    }
}
