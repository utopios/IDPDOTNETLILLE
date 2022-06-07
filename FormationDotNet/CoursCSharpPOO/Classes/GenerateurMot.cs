using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class GenerateurMot
    {
        private string[] mots = new string[] { "google", "amazon", "facebook", "apple", "microsoft" };
        private Random random = new Random();
        public string Generer()
        {
            //A coder
            
            return mots[random.Next(0, mots.Length)];
        }
    }
}
