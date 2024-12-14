using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassUser2
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }

        public ClassUser2() { }
        public ClassUser2(string name, string surname, string login)
        {
            Name = name;
            Surname = surname;
            Login = login;
        }
        public void ReversLogin(string newLogin)
        {
            Login = newLogin;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}; Фамилия: {Surname}; Логин: {Login}");
        }
    }
}
