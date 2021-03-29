using System.Collections.Generic;
using MiniBank.Entities.Concrete;

namespace MiniBank.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        List<User> GetAll(string word);
        void Register(User user);
        User Login(string username, string password);
        User Get(int customerId);
        void Update(User user);
        void Delete(User user);
    }
}
