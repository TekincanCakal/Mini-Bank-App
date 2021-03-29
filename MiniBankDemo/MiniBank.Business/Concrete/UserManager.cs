using System;
using System.Collections.Generic;
using MiniBank.Business.Abstract;
using MiniBank.DataAcces.Abstract;
using MiniBank.Entities.Concrete;

namespace MiniBank.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }
        public List<User> GetAll(string word)
        {
            return _userDal.GetAll(p => p.Username.Contains(word) ||
                                        p.CustomerId.ToString().Contains(word) ||
                                        p.FirstName.Contains(word) ||
                                        p.IdentityNumber.ToString().Contains(word));
        }
        public void Register(User user)
        {
            _userDal.Add(user);
        }
        public User Login(string username, string password)
        {
            User tempUser = _userDal.Get(p => p.Username.Equals(username));
            if (tempUser == null)
            {
                throw new Exception("This username is not registered");
            }
            else if(!tempUser.Password.Equals(password))
            {
                throw new Exception("Password is wrong");
            }
            else if (tempUser.Perm == 0)
            {
                throw new Exception("Your perm is not enough for login admin panel");
            }
            else
            {
                return tempUser;
            }
        }
        public User Get(int customerId)
        {
            return _userDal.Get(p => p.CustomerId == customerId);
        }
        public void Delete(User user)
        {
            _userDal.Delete(user);
        }
        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
