using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassBank
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityUser { get; set; }

        public ClassBank() { }
        public ClassBank(string name, string address, int quanityUser)
        {
            Name = name;
            Address = address;
            QuanityUser = quanityUser;
        }
        public void ReversQuanityUser(int newQuanityUser)
        {
            QuanityUser = newQuanityUser;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество Клиентов: {QuanityUser}");
        }
    }
}
