using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogic;
using Entities;

namespace Interface
{
    class Program
    {
        static UserLogic userLogic = new UserLogic();
        static AnswardLogic answardLogic = new AnswardLogic();
        static void Main()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1.Вывести список пользователей!");
            Console.WriteLine("2.Добавить пользователя!");
            Console.WriteLine("3.Удалить пользователя!");
            Console.WriteLine("4.Вывести награды!");
            Console.WriteLine("5.Добавить награду!");
            Console.WriteLine("6.Присвоить награду!");
            Console.WriteLine("7.Вывести награды пользователей!");
            UserLogic user = new UserLogic();
            switch (Console.ReadLine())
            {
                case "1":
                    IEnumerable<User<string>> users = userLogic.GetAll();
                    foreach (var v in users)
                    {
                        Console.WriteLine(v);
                    }
                    Main();
                    break;
                case "2":
                   
                    Console.WriteLine("Введите имя: ");
                    string Name = Console.ReadLine();

                    Console.WriteLine("Введите дату рождения: ");
                    string Date = Console.ReadLine();
                    string[] date = Date.Split('.');
                    DateTime datetime = new DateTime(int.Parse(date[2]),int.Parse(date[1]),int.Parse(date[0]));

                    DateTime dateNow = DateTime.Now;
                    int year = dateNow.Year - datetime.Year;
                    if (dateNow.Month < datetime.Month ||
                        (dateNow.Month == datetime.Month && dateNow.Day < datetime.Day)) year--;

                    user.Add(new User<int>(Name,datetime,year));
                    Main();
                    break;
                case "3":
                    Console.WriteLine("Введите ID пользователя: ");
                    string id = Console.ReadLine();

                    user.Remove(int.Parse(id));
                    Main();
                    break;
                case "4":
                    IEnumerable<Answard> answards = answardLogic.GetAll();
                    foreach (var v in answards)
                    {
                        Console.WriteLine(v);
                    }
                    Main();
                    break;
                case "5":
                    Console.WriteLine("Введите название: ");
                    string Title = Console.ReadLine();
                    answardLogic.Add(new Answard(Title));
                    Main();
                    break;
                case "6":
                    Console.WriteLine("Введите ID_User: ");
                    int idU = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите ID_Answard: ");
                    int idA = int.Parse(Console.ReadLine());
                    answardLogic.Present(new PresentAnsward(idU,idA));
                    Main();
                    break;
                case "7":
                    answardLogic.GetPresentAnsward();
                    Main();
                    break;
            }
        }
    }
}
