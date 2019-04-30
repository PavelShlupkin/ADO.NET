using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_TASK_FIRST
{
    public class User
    {
        private string firstname;
        private string surname;
        private string patronymic;
        private DateTime dateofbirth;
        private string age;


        public User(string firstname, string surname, string patronymic, DateTime dateofbirth, string age)
        {
            FirstName = firstname;
            SurName = surname;
            Patronymic = patronymic;
            DateOfBirth = dateofbirth;
            Age = age;
        }

        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    firstname = value;
                }
                else
                {
                    throw new ArgumentException("Wrong name");
                }
            }
        }

        public string SurName
        {
            get
            {
                return surname;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    surname = value;
                }
                else
                {
                    throw new ArgumentException("Wrong surname");
                }
            }
        }

        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    patronymic = value;
                }
                else
                {
                    throw new ArgumentException("Wrong patronymic");
                }
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateofbirth;
            }
            set
            {
                dateofbirth = value;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || !int.TryParse(value, out int a) || a < 0)
                {
                    throw new ArgumentException("Invalid age!");
                }
                age = value;
            }
        }

        public override string ToString()
        {
            return ($"Имя: {FirstName}, Фамилия: {SurName}, Отчество: {Patronymic}, Дата рождения: {DateOfBirth.ToLongDateString()}, Возраст: {Age}");
        }


    }
}
