using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class Moto
    {
        private decimal prix;
        public event Action<decimal> Promotion;
        public decimal Prix { get => prix; set => prix = value; }
    
        public void Reduction(decimal montant)
        {
            Prix -= montant;
            if (Promotion != null)
                Promotion(Prix);
        }
    }
}
