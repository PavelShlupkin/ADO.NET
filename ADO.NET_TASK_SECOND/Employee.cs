using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_TASK_FIRST
{
    class Employee : User
    {
        private string experience;
        private string post;

        public string Experience
        {
            get
            {
                return experience;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || !int.TryParse(value, out int e) || e < 0)
                {
                    throw new ArgumentException("Invalid experience!");
                }
                experience = value;
            }
        }
        public string Post
        {
            get
            {
                return post;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    post = value;
                }
                else
                {
                    throw new ArgumentException("Invalid position!");
                }
            }
        }

        public Employee(string firstname, string surname, string patronymic, DateTime dateofbirth, string age, string experience, string post) : base(firstname, surname, patronymic, dateofbirth, age)
        {
            Experience = experience;
            Post = post;
        }
        public override string ToString()
        {
            return ($"ФИО: {FirstName} {SurName} {Patronymic}, Дата рождения: {DateOfBirth.ToLongDateString()}, Возраст: {Age}, Стаж: {Experience}, Должность: {Post}");
        }
    }
}
