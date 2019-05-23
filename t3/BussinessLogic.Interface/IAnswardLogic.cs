using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BussinessLogic.Interface
{
    public interface IAnswardLogic
    {
        IEnumerable<Answard> GetAll();

        IEnumerable<Answard> GetPresentAnsward();

        void Add(Answard value);

        void Present(PresentAnsward value);

        void Remove(int ID);

        Answard GetByID(int ID);
    }
}
