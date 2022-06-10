using CoursCSharpPOO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class Maison<T> : IAvancer
    {
        private T[] elements;

        public Maison()
        {
            elements = new T[10];
        }

        public void Avancer()
        {
            Console.WriteLine("Une maison qui avance");
        }

        public void Entrer(T element)
        {
            //Code....
        }
        public void Sortir(T element)
        {
            //Code...
        }
    }
}
