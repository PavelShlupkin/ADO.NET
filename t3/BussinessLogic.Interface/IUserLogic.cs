using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BussinessLogic.Interface
{
    public interface IUserLogic
    {
        IEnumerable<User<string>> GetAll();

        void Add(User<int> value);

        void Remove(int ID);

        User<int> GetByID(int ID);
    }
}
