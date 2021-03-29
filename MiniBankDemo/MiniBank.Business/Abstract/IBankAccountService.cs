using System.Collections.Generic;
using MiniBank.Entities.Concrete;

namespace MiniBank.Business.Abstract
{
    public interface IBankAccountService
    {
        List<BankAccount> GetAll();
        List<BankAccount> GetAll(string word);
        string GetRandomIBAN();
        string GetRandomBankAccountNumber(int CustomerId);
        void Register(BankAccount bankAccount);
        BankAccount Get(string bankAccountNumber);
        void Delete(BankAccount bankAccount);
        void Update(BankAccount bankAccount);
    }
}
