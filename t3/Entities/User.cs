using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User<T>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBrith { get; set; }
        public int Age { get; set; }
        public User()
        { }
        public User(string name, DateTime dateOfBrith,int age)
        {
            Name = name;
            DateOfBrith = dateOfBrith;
            Age = age;
        }
        public override string ToString()
        {
            return $"{ID}. Имя: {Name} Дата Рождения: {DateOfBrith.ToShortDateString()} Возраст: {Age}";
        }
    }
}
