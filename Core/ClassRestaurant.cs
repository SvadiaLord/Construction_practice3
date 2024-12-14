using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassRestaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityDishes { get; set; }

        public ClassRestaurant() { }
        public ClassRestaurant(string name, string address, int quanityDishes)
        {
            Name = name;
            Address = address;
            QuanityDishes = quanityDishes;
        }
        public void ReversQuanityDishes(int newQuanityDishes)
        {
            QuanityDishes = newQuanityDishes;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество блюд: {QuanityDishes}");
        }
    }
}
