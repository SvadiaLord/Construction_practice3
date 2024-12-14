using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassZoo
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityAnimal { get; set; }

        public ClassZoo() { }
        public ClassZoo(string name, string address, int quanityAnimal)
        {
            Name = name;
            Address = address;
            QuanityAnimal = quanityAnimal;
        }
        public void ReversQuanityAnimal(int newQuanityAnimal)
        {
            QuanityAnimal = newQuanityAnimal;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество животных: {QuanityAnimal}");
        }
    }
}
