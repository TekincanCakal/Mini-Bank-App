using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MiniBank.Entities.Abstract;

namespace MiniBank.Entities.Concrete
{
    [Table("Users")]
    public class User : IEntity
    {
        [Key]
        public int CustomerId { get; set; }
        public long IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Perm { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
