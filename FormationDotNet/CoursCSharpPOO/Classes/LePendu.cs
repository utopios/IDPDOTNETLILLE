using CoursCSharpPOO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    public class LePendu
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
            bool found = false;
            string masqueTmp = "";
            for(int i=0; i < motATrouve.Length; i++)
            {
                if(motATrouve[i] == c)
                {
                    found = true;
                    masqueTmp += c;
                }
                else
                {
                    masqueTmp += masque[i];
                }
            }
            masque = masqueTmp;
            if(!found)
            {
                nbEssai--;
            }
            return found;
        }

        public bool TestWin()
        {
            //A coder
            return motATrouve == masque;
        }

        public void GenererMasque(IGenerateur generateur)
        {
            //A coder
            string masqueTmp = "";
            motATrouve = generateur.Generer();
            for(int i=0; i < motATrouve.Length; i++)
            {
                masqueTmp += "*";
            }
            masque = masqueTmp;
        }
    }
}
