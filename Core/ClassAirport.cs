using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassAirport
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityFlight { get; set; }

        public ClassAirport() { }
        public ClassAirport(string name, string address, int quanityFlight)
        {
            Name = name;
            Address = address;
            QuanityFlight = quanityFlight;
        }
        public void ReversQuanityFlight(int newQuanityFlight)
        {
            QuanityFlight = newQuanityFlight;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество рейсов: {QuanityFlight}");
        }
    }
}
