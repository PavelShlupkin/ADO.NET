using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BussinessLogic;
using DAL;

namespace BussinessLogic
{
    public class AnswardLogic
    {
        private AnswardDAO answardDao = new AnswardDAO();
        public void Add(Answard value)
        {
            answardDao.Add(value);
        }

        public void Present(PresentAnsward value)
        {
            answardDao.Present(value);
        }

        public IEnumerable<Answard> GetAll()
        {
            return answardDao.GetAll();
        }
        public IEnumerable<Answard> GetPresentAnsward()
        {
            return answardDao.GetPresentAnsward();
        }

        public Answard GetByID(int ID)
        {
            return answardDao.GetByID(ID);
        }

        public void Remove(int ID)
        {
            answardDao.RemoveByID(ID);
        }
    }
}
