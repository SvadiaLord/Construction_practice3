using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassRailway
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityTrain { get; set; }

        public ClassRailway() { }
        public ClassRailway(string name, string address, int quanityTrain)
        {
            Name = name;
            Address = address;
            QuanityTrain = quanityTrain;
        }
        public void ReversQuanityTrain(int newQuanityTrain)
        {
            QuanityTrain = newQuanityTrain;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество поездов: {QuanityTrain}");
        }
    }
}
