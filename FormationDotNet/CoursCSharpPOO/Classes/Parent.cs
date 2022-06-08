using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class Parent
    {
        private string name;
        private int number;

        public string Name { get => name; set => name = value; }
        public int Number { get => number; set => number = value; }
        public Parent()
        {

        }
        public Parent(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public void Afficher()
        {
            Console.WriteLine($"{Name} {Number}");
        }
    }
}
