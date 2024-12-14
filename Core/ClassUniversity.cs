using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassUniversity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityStudent { get; set; }

        public ClassUniversity() { }
        public ClassUniversity(string name, string address, int quanityStudent)
        {
            Name = name;
            Address = address;
            QuanityStudent = quanityStudent;
        }
        public void ReversQuanityStudent(int newQuanityStudent)
        {
            QuanityStudent = newQuanityStudent;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество студентов: {QuanityStudent}");
        }
    }
}
