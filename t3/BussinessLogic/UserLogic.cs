using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogic.Interface;
using Entities;
using DAL;

namespace BussinessLogic
{
    public class UserLogic:IUserLogic
    {
        private UserDAO userDao = new UserDAO();
        public void Add(User<int> value)
        {
            userDao.Add(value);
        }

        public IEnumerable<User<string>> GetAll()
        {
            return userDao.GetAll();
        }

        public User<int> GetByID(int ID)
        {
            return userDao.GetByID(ID);
        }

        public void Remove(int ID)
        {
            userDao.RemoveByID(ID);
        }
    }
}
