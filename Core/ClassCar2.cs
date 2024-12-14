using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassCar2
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public ClassCar2() { }
        public ClassCar2(string make, string model, int year)
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
