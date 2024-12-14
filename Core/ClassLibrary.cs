using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassLibrary
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityBook { get; set; }

        public ClassLibrary() { }
        public ClassLibrary(string name, string address, int quanityBook)
        {
            Name = name;
            Address = address;
            QuanityBook = quanityBook;
        }
        public void ReversQuanityiBook(int newQuanityBook)
        {
            QuanityBook = newQuanityBook;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество книг: {QuanityBook}");
        }
    }
}
