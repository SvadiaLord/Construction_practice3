using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassGarden
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityFlowers { get; set; }

        public ClassGarden() { }
        public ClassGarden(string name, string address, int quanityFlowers)
        {
            Name = name;
            Address = address;
            QuanityFlowers = quanityFlowers;
        }
        public void ReversQuanityFlowers(int newQuanityFlowers)
        {
            QuanityFlowers = newQuanityFlowers;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество цветов: {QuanityFlowers}");
        }
    }
}
