using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    abstract class VehiculeAMoteur : Vehicule
    {
        private Moteur moteurV;
        public Moteur MoteurV { get => moteurV; set => moteurV = value; }
        protected VehiculeAMoteur(string marque, string model) : base(marque, model)
        {
            MoteurV = new Moteur();
        }

        public override bool Demarrer()
        {
            return MoteurV.Demarrer();
        }

        public override void Arreter()
        {
            MoteurV.Arreter();
        }

        public override void FairePlein(double volume)
        {
            MoteurV.Arreter();
            MoteurV.FairePlein(volume);
            MoteurV.Demarrer();
        }
    }
}
