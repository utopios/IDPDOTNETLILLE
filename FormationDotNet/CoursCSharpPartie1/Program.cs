
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace CoursCSharpPartie1
{
    class Program
    {
        public static void Main(String[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Utilisation des variables
            //Déclaration d'une variables
            /*string nomComplet = "abadi ihab";
            int age = 34;
            Console.WriteLine(nomComplet);
            Console.WriteLine(age);
            int @int = 10;*/
            //int a, b;
            //a = 10;
            //b = 20;
            //Console.WriteLine(a + " " + b);
            //decimal a = 10;
            //double b = 10;
            //Console.WriteLine(a + b);
            //Convertion des variables.
            //string a = "10,4";
            //double b = 30 + Convert.ToDouble(a);
            //Console.WriteLine(b);

            //Utilisation de la console
            //Ecrire dans la console
            //Console.WriteLine("Bonjour tout le monde");
            //Console.Write("Toto");
            //Console.Write("tata");
            //Lire dans la console
            //string saisi = Console.ReadLine();
            //Console.WriteLine(saisi);

            //Correction exercice 3
            /*Console.Write("Merci de saisir votre nom : ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir votre prénom : ");
            string prenom = Console.ReadLine();
            //Console.WriteLine("Bonjour " + nom + " " + prenom);
            //Console.WriteLine($"Bonjour {nom} {prenom}");
            
            //Correction partie exercice 4
            Console.Write("Merci de saisir votre age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Bonjour {nom} {prenom}, vous avez {age} ans");*/

            //Correction exercice 5
            //Console.Write("Merci de saisir le premier nombre : ");
            //double premierNombre = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Merci de saisir le second nombre : ");
            //double secondNombre = Convert.ToDouble(Console.ReadLine());
            //double resultat = premierNombre + secondNombre;
            //Console.WriteLine($"Le result de l'addition de {premierNombre} et {secondNombre} est égale à {resultat}");

            //Correction exercice 7
            //Console.Write("Merci de saisir la longueur du premier côté : ");
            //double first = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Merci de saisir la longueur du second côté : ");
            //double second= Convert.ToDouble(Console.ReadLine());
            //double hypo = Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2));
            //Console.WriteLine($"L'hypothénuse est de {Math.Round(hypo, 2)}");

            //Structure de controle
            //if else
            //bool test = false;
            //if(test)
            //{
            //    Console.WriteLine("Le test est true");
            //}
            //else
            //{
            //    Console.WriteLine("Le test est faux");
            //}
            //int a = 10;
            //if(a > 10)
            //{
            //    Console.WriteLine("A est > 0");
            //}
            //else if(a > 5 && a <= 10)
            //{
            //    Console.WriteLine("A est > 5 et <= 10");
            //}
            //else
            //{
            //    Console.WriteLine("A est <= 5");
            //}
            //Correction exercice 10
            //Console.Write("Merci de sasir  une lettre : ");
            //string lettre = Console.ReadLine();
            //if(lettre == "e" || lettre == "a" || lettre =="o" || lettre == "u" || lettre == "y" || lettre == "i")
            //{
            //    Console.WriteLine("La lettre est une voyelle");
            //}
            //else
            //{
            //    Console.WriteLine("Une consonne");
            //}

            //Correction exercice 11
            /*Console.Write("Merci de saisir un nombre entier : ");
            int nb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Merci de saisir un le diviseur : ");
            int diviseur = Convert.ToInt32(Console.ReadLine());
            string type = nb < 10 ? "chiffre" : "nombre";
            if(nb % diviseur == 0)
            {
                Console.WriteLine($"{type} {nb} est divisible par {diviseur}");
            }
            else
            {
                Console.WriteLine($"Le {type} n'est pas divisible");
            }*/
            //Correction exercice 13
            /*Console.Write("Merci de saisir AB : ");
            double ab = Convert.ToInt32(Console.ReadLine());
            Console.Write("Merci de saisir AC : ");
            double ac = Convert.ToInt32(Console.ReadLine());
            Console.Write("Merci de saisir BC : ");
            double bc = Convert.ToInt32(Console.ReadLine());
            if(ab == ac)
            {
                if(ab == bc)
                {
                    Console.WriteLine("Equilatéral");
                }
                else
                {
                    Console.WriteLine("Isocèle en A");
                }
            }
            else if(ac == bc)
            {
                Console.WriteLine("Isocèle en C");
            }
            else if(ab == bc)
            {
                Console.WriteLine("Isocèle en B");
            }
            else
            {
                Console.WriteLine("rien");
            }*/
            //Correction exercice 14
            //Console.Write("Merci de saisir votre poids : ");
            //ushort poids = Convert.ToUInt16(Console.ReadLine());
            //Console.Write("Merci de saisir votre taille : ");
            //ushort taille = Convert.ToUInt16(Console.ReadLine());
            //if((taille >= 145 && taille <= 169 && poids >= 43 && poids <= 47) || (taille >= 145 && taille <= 166 && poids >= 48 && poids <= 53) || (taille >= 145 && taille <= 163 && poids >= 54 && poids <= 59) || (taille >= 145 && taille <= 160 && poids >= 60 && poids <= 65))
            //{
            //    Console.WriteLine("Taille 1");
            //}
            //else if((taille >= 145 && taille <= 169 && poids >= 43 && poids <= 47) || (taille >= 145 && taille <= 166 && poids >= 48 && poids <= 53) || (taille >= 145 && taille <= 163 && poids >= 54 && poids <= 59) || (taille >= 145 && taille <= 160 && poids >= 60 && poids <= 65))
            //{
            //    Console.WriteLine("taille 2");
            //}
            //else if ((taille >= 145 && taille <= 169 && poids >= 43 && poids <= 47) || (taille >= 145 && taille <= 166 && poids >= 48 && poids <= 53) || (taille >= 145 && taille <= 163 && poids >= 54 && poids <= 59) || (taille >= 145 && taille <= 160 && poids >= 60 && poids <= 65))
            //{
            //    Console.WriteLine("taille 3");
            //}
            //else
            //{
            //    Console.WriteLine("Aucune taille");
            //}

            //Correction Exercice 15
            Console.Write("Merci saisir le dernier salaire : ");
            decimal salaire = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Merci saisir votre âge : ");
            ushort age = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Merci saisir le nombre d'années d'anciennete : ");
            ushort anc = Convert.ToUInt16(Console.ReadLine());
            decimal ind = 0;
            if(anc > 10)
            {
                ind += (anc - 10) * salaire + 10 * salaire / 2;
                //anc -= 10;
            }
            else if (anc >= 1)
            {
                ind += anc * salaire / 2;
            }
            //ind += anc * salaire / 2;
            if(age >= 50)
            {
                ind += 5 * salaire;
            }
            else if(age >= 46)
            {
                ind += 2 * salaire;
            }

            Console.WriteLine($"Votre indemnité est de {ind} euros");
        }
    }
}