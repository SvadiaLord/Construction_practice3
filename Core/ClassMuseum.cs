using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassMuseum
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityExhibit { get; set; }

        public ClassMuseum() { }
        public ClassMuseum(string name, string address, int quanityExhibit)
        {
            Name = name;
            Address = address;
            QuanityExhibit = quanityExhibit;
        }
        public void ReversQuanityExhibit(int newQuanityExhibit)
        {
            QuanityExhibit = newQuanityExhibit;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество экспонатов: {QuanityExhibit}");
        }
    }
}
