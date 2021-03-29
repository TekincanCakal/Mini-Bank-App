using System.Collections.Generic;
using MiniBank.Entities.Concrete;

namespace MiniBank.Business.Abstract
{
    public interface ICreditCardService
    {
        List<CreditCard> GetAll();
        void Register(CreditCard creditCard);
        string GetRandomCardNumber();
    }
}
