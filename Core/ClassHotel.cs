using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassHotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityNumbers { get; set; }

        public ClassHotel() { }
        public ClassHotel(string name, string address, int quanityNumbers)
        {
            Name = name;
            Address = address;
            QuanityNumbers = quanityNumbers;
        }
        public void ReversQuanityNumbers(int newQuanityNumbers)
        {
            QuanityNumbers = newQuanityNumbers;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество номеров: {QuanityNumbers}");
        }
    }
}
