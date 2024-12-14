using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3.Core
{
    internal class ClassPark
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuanityTrees { get; set; }

        public ClassPark() { }
        public ClassPark(string name, string address, int quanityTrees)
        {
            Name = name;
            Address = address;
            QuanityTrees = quanityTrees;
        }
        public void ReversQuanityTrees(int newQuanityTrees)
        {
            QuanityTrees = newQuanityTrees;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name} Адрес: {Address} Количество деревьев: {QuanityTrees}");
        }
    }
}
