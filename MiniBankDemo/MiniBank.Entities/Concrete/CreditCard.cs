using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MiniBank.Entities.Abstract;

namespace MiniBank.Entities.Concrete
{
    [Table("CreditCards")]
    public class CreditCard : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }
        public int CutOffDay { get; set; }
        public int DueDay { get; set; }
        public decimal SpentMoney { get; set; }
        public string CardNumber { get; set; }
    }
}
