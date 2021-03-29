using System;
using System.Collections.Generic;
using MiniBank.Business.Abstract;
using MiniBank.DataAcces.Abstract;
using MiniBank.Entities.Concrete;

namespace MiniBank.Business.Concrete
{
    class CreditCardManager : ICreditCardService
    {
        private ICreditCardDal _creditCardDal;
        private ILogService _logService;
        public CreditCardManager(ICreditCardDal creditCardDal, ILogService logService)
        {
            _creditCardDal = creditCardDal;
            _logService = logService;
        }
        public List<CreditCard> GetAll()
        {
            return _creditCardDal.GetAll();
        }
        public void Register(CreditCard creditCard)
        {
            DateTime dt = DateTime.Now;
            _logService.Log(new Log
            {
                Text = "Credit Card created at " + dt,
                Date = dt,
                CardNumber = creditCard.CardNumber
            });
            _creditCardDal.Add(creditCard);
        }
        public string GetRandomCardNumber()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1000, 10000);
            int num2 = rnd.Next(1000, 10000);
            int num3 = rnd.Next(1000, 10000);
            string temp = String.Format("4446 {0} {1} {2}", num1, num2, num3);
            if (_creditCardDal.Get(p => p.CardNumber == temp) == null)
            {
                return temp;
            }
            return GetRandomCardNumber();
        }
    }
}
