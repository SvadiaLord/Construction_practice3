using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassStation
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityBus { get; set; }

        public ClassStation() { }
        public ClassStation(string name, string address, int quanityBus)
        {
            Name = name;
            Address = address;
            QuanityBus = quanityBus;
        }
        public void ReversQuanityBus(int newQuanityBus)
        {
            QuanityBus = newQuanityBus;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество автобусов: {QuanityBus}");
        }
    }
}
