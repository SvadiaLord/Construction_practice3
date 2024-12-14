using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassProduct2
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quanity { get; set; }

        public ClassProduct2() { }
        public ClassProduct2(string name, double price, int quanity)
        {
            Name = name;
            Price = price;
            Quanity = quanity;
        }
        public void ReversPrice(double newPrice)
        {
            Price = newPrice;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}; Цена: {Price}; Количество: {Quanity}");
        }
    }
}
