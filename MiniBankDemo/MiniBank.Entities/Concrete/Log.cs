using System;
using MiniBank.Entities.Abstract;

namespace MiniBank.Entities.Concrete
{
    public class Log : IEntity
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string CardNumber { get; set; }
    }
}
