using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassAquarium
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityFish { get; set; }

        public ClassAquarium() { }
        public ClassAquarium(string name, string address, int quanityFish)
        {
            Name = name;
            Address = address;
            QuanityFish = quanityFish;
        }
        public void ReversQuanityFish(int newQuanityFish)
        {
            QuanityFish = newQuanityFish;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество рыб: {QuanityFish}");
        }
    }
}
