using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Answard
    {
        public int ID { get; set; }
        public string Title { get; set; }
      
        public Answard()
        { }
        public Answard(string name)
        {
            Title = name;
        }
        public override string ToString()
        {
            return $"{ID}. Название: {Title}";
        }
    }
}
