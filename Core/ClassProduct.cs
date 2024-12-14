using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassProduct
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public int Quanity { get; set; }

        public ClassProduct() { }   
        public ClassProduct(double price, string name, int quanity)
        {
            Price = price;
            Name = name;
            Quanity = quanity;
        }
        public void ReversPrice(double newPrice)
        {
            Price = newPrice;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Цена: {Price}; Имя: {Name}; Количество: {Quanity}");
        }
    }
}
