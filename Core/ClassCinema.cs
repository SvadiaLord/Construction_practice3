using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassCinema
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityFilm { get; set; }

        public ClassCinema() { }
        public ClassCinema(string name, string address, int quanityFilm)
        {
            Name = name;
            Address = address;
            QuanityFilm = quanityFilm;
        }
        public void ReversQuanityFilm(int newQuanityFilm)
        {
            QuanityFilm = newQuanityFilm;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество фильмов: {QuanityFilm}");
        }
    }
}
