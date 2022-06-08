using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class Commercial : Salarie
    {
        private decimal chiffreAffaire;
        private decimal commission;
        public Commercial(string matricule, string nom, string categorie, string service, decimal salaire, decimal chiffre, decimal commission) : base(matricule, nom, categorie, service, salaire)
        {
            ChiffreAffaire = chiffre;
            Commission = commission;
        }

        public override decimal CalculerSalaire()
        {
            return base.CalculerSalaire() + ChiffreAffaire * Commission / 100; 
        }

        public decimal ChiffreAffaire { get => chiffreAffaire; set => chiffreAffaire = value; }
        public decimal Commission { get => commission; set => commission = value; }
    }
}
