using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassShop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Quanity { get; set; }
        
        public ClassShop() { }
        public ClassShop(string name, string address, int quanity)
        {
            Name = name;
            Address = address;
            Quanity = quanity;
        }
        public void ReversQuanity(int newQuanity)
        {
            Quanity = newQuanity;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}; Адрес: {Address}; Количество: {Quanity}");
        }
    }
}
