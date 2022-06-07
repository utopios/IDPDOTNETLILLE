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
            lePendu.GenererMasque(generateur);
            do
            {
                Console.WriteLine(lePendu.Masque);
                Console.Write("Merci de saisir une lettre : ");
                char c = Convert.ToChar(Console.ReadLine());
                if(lePendu.TestChar(c))
                {
                    Console.WriteLine("Bravo vous avez trouvé une lettre ");
                }
                else
                {
                    Console.WriteLine($"Il vous reste {lePendu.NbEssai} essais");
                }
            } while (lePendu.NbEssai > 0 && !lePendu.TestWin());
            if(lePendu.NbEssai > 0)
            {
                Console.WriteLine("Bravo vous avez gagné");
            }

        }
    }
}
