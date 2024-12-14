using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassTheater
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityPerformance { get; set; }

        public ClassTheater() { }
        public ClassTheater(string name, string address, int quanityPerformance)
        {
            Name = name;
            Address = address;
            QuanityPerformance = quanityPerformance;
        }
        public void ReversQuanityPerformance(int newQuanityPerformance)
        {
            QuanityPerformance = newQuanityPerformance;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество спектаклей: {QuanityPerformance}");
        }
    }
}
