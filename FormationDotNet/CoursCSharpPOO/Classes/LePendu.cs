using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class LePendu
    {
        private int nbEssai;
        private string masque;
        private string motATrouve;

        public int NbEssai { get => nbEssai; }
        public string Masque { get => masque;  }
        public string MotATrouve { get => motATrouve; }

        public LePendu()
        {
            nbEssai = 10;
        }

        public bool TestChar(char c)
        {
            //A coder
            return false;
        }

        public bool TestWin()
        {
            //A coder
            return false;
        }

        public void GenererMasque(GenerateurMot generateur)
        {
            //A coder
        }
    }
}
