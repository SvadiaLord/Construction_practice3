using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassBook
    {
        public string Athor {get;set;}
        public int Year { get; set; }

        public ClassBook() { }
        public ClassBook(string athor, int year)
        {
            Athor = athor;
            Year = year;
        }
        public void ReversAthor(string newAthor)
        {
            Athor = newAthor;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Автор: {Athor}; Год издания: {Year}");
        }
    }
}
