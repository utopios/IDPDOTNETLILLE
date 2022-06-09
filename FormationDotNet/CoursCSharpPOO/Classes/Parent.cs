using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    abstract class Parent
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

        public virtual void Afficher()
        {
            Console.WriteLine($"{Name} {Number}");
        }

        public abstract void MethodeAbstract();
    }
}
