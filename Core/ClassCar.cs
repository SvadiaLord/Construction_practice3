using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassCar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public ClassCar() { }
        public ClassCar(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public void Information()
        {
            Console.WriteLine("Не бита, не крашена, прямо с завода!");
        }
        public void ReversMake(string newMake)
        {
            Make = newMake;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Марка: {Make}; Модель: {Model}; Год выпуска: {Year}");
        }
    }
}
