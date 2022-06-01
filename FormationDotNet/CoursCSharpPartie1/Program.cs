
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
            Console.Write("Merci de sasir  une lettre : ");
            string lettre = Console.ReadLine();
            if(lettre == "e" || lettre == "a" || lettre =="o" || lettre == "u" || lettre == "y" || lettre == "i")
            {
                Console.WriteLine("La lettre est une voyelle");
            }
            else
            {
                Console.WriteLine("Une consonne");
            }
        }
    }
}