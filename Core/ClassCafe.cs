using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassCafe
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityDrink { get; set; }

        public ClassCafe() { }
        public ClassCafe(string name, string address, int quanityDrink)
        {
            Name = name;
            Address = address;
            QuanityDrink = quanityDrink;
        }
        public void ReversQuanityDrink(int newQuanityDrink)
        {
            QuanityDrink = newQuanityDrink;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество напитков: {QuanityDrink}");
        }
    }
}
