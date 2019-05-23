using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL.Interface
{
    public interface IUserDao
    {
        IEnumerable<User<string>> GetAll();

        void Add(User<int> value);

        void RemoveByID(int ID);

        User<int> GetByID(int ID);
    }
}
