using System;
using System.Collections.Generic;
using MiniBank.Business.Abstract;
using MiniBank.DataAcces.Abstract;
using MiniBank.Entities.Concrete;

namespace MiniBank.Business.Concrete
{
    class BankAccountManager : IBankAccountService
    {
        private IBankAccountDal _bankAccount;
        public BankAccountManager(IBankAccountDal bankAccount)
        {
            _bankAccount = bankAccount;
        }
        public List<BankAccount> GetAll()
        {
            return _bankAccount.GetAll();
        }
        public List<BankAccount> GetAll(string word)
        {
            return _bankAccount.GetAll(p => p.BankAccountNumber.Contains(word) ||
                                            p.CustomerId.ToString().Contains(word) ||
                                            p.Iban.Contains(word));
        }
        public BankAccount Get(string bankAccountNumber)
        {
            return _bankAccount.Get(p => p.BankAccountNumber == bankAccountNumber);
        }
        public string GetRandomIBAN()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1000, 10000);
            int num2 = rnd.Next(1000, 10000);
            int num3 = rnd.Next(1000, 10000);
            int num4 = rnd.Next(1000, 10000);
            string temp = String.Format("TR 0001 {0} {1} {2} {3} 5001", num1, num2, num3, num4);
            if (_bankAccount.Get(p => p.Iban == temp) == null)
            {
                return temp;
            }
            return GetRandomIBAN();
        }
        public string GetRandomBankAccountNumber(int CustomerId)
        {
            string temp = String.Format("0755 {0} {1}", CustomerId, new Random().Next(1000, 10000));
            if (_bankAccount.Get(p => p.BankAccountNumber == temp) == null)
            {
                return temp;
            }
            return GetRandomBankAccountNumber(CustomerId);
        }
        public void Register(BankAccount bankAccount)
        {
            _bankAccount.Add(bankAccount);
        }
        public void Delete(BankAccount bankAccount)
        {
            _bankAccount.Delete(bankAccount);
        }
        public void Update(BankAccount bankAccount)
        {
            _bankAccount.Update(bankAccount);
        }
    }
}
