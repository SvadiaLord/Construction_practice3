using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassStudent
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public ClassStudent() { }
        public ClassStudent(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void ReversAge(int newAge)
        {
            Age = newAge;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}; Фамилия: {Surname}; Возраст: {Age}");
        }
    }
}
