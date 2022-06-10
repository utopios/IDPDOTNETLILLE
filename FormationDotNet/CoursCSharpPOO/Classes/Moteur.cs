using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class Moteur
    {
        private double volumeReservoir;
        private double volumeTotal;
        private bool demarre;

        public double VolumeReservoir { get => volumeReservoir; set => volumeReservoir = value; }
        public double VolumeTotal { get => volumeTotal; set => volumeTotal = value; }
        public bool Demarre { get => demarre; set => demarre = value; }

        public bool Demarrer()
        {
            if(!demarre && volumeReservoir > 0.1)
            {
                demarre = true;
                Console.WriteLine("Je démarre...");
                volumeReservoir -= 0.1;
                return true;
            }
            return false;

        }

        public bool Utiliser(double volume)
        {
            if(demarre)
            {
                if(volumeReservoir > volume)
                {
                    volumeReservoir -= volume;
                    Console.WriteLine($"J'utilise {volume}...");
                }
                else
                {
                    Console.WriteLine($"J'utilise {volumeReservoir}...");
                    Console.WriteLine("Il faut faire le plein pour aller plus loin");
                    volumeReservoir = 0; 
                }
                return true;
            }
            return false;
        }

        public void FairePlein(double volume)
        {
            VolumeReservoir += volume;
            VolumeTotal += volume;
            Console.WriteLine($"Je fais le plein avec {volume}");
        }

        public bool Arreter()
        {
            Console.WriteLine("Je m'arrete...");
            return false;
        }
    }
}
