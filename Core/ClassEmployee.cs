using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }

        public ClassEmployee() { }
        public ClassEmployee(string name, string surname, string position)
        {
            Name = name;
            Surname = surname;
            Position = position;
        }
        public void ReversPosition(string newPosition)
        {
            Position = newPosition;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}; Фамилия: {Surname}; Должность: {Position}");
        }
    }
}
