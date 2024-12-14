using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassTicher
    {
        public string Name { get; set; }
        public string Surname { get; set; } 
        public string Lesson { get; set;  }
        public ClassTicher() { }
        public ClassTicher(string name, string surname, string lesson)
        {
            Name = name;
            Surname = surname;
            Lesson = lesson;
        }
        public void ReversLesson(string newLesson)
        {
            Lesson = newLesson;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($" Имя: {Name}; Фамилия: {Surname}; Предмет: {Lesson} ");
        }
    }
}
