using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    abstract class Vehicule
    {
        private string marque;
        private string model;

        public string Marque { get => marque; set => marque = value; }
        public string Model { get => model; set => model = value; }

        public Vehicule(string marque, string model)
        {
            Marque = marque;
            Model = model;
        }

        public abstract bool Demarrer();
        public abstract void Arreter();

        public abstract void FairePlein(double volume);
    }
}
