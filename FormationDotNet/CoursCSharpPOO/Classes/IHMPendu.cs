using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class IHMPendu
    {
        private LePendu lePendu;
        private GenerateurMot generateur;

        public IHMPendu()
        {
            lePendu = new LePendu();
            generateur = new GenerateurMot();
        }

        public void Jouer()
        {
            //A coder
        }
    }
}
