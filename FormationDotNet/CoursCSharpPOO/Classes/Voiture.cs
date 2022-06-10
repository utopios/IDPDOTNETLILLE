using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class Voiture : VehiculeAMoteur
    {
        public Voiture(string marque, string model, double volumeInitial) : base(marque, model)
        {
            MoteurV.VolumeReservoir = volumeInitial;
            MoteurV.VolumeTotal = volumeInitial;
        }

        public void Rouler(double volume)
        {
            if(!MoteurV.Demarre)
            {
                Demarrer();
            }
            MoteurV.Utiliser(volume);
        }

        public override string ToString()
        {
            return $"Marque : {Marque}, Model {Model}, Resevoir {MoteurV.VolumeReservoir}";
        }
    }
}
