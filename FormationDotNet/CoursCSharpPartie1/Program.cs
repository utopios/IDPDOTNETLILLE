﻿
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
            //Console.Write("Merci saisir le dernier salaire : ");
            //decimal salaire = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Merci saisir votre âge : ");
            //ushort age = Convert.ToUInt16(Console.ReadLine());
            //Console.Write("Merci saisir le nombre d'années d'anciennete : ");
            //ushort anc = Convert.ToUInt16(Console.ReadLine());
            //decimal ind = 0;
            //if(anc > 10)
            //{
            //    ind += (anc - 10) * salaire + 10 * salaire / 2;
            //    //anc -= 10;
            //}
            //else if (anc >= 1)
            //{
            //    ind += anc * salaire / 2;
            //}
            ////ind += anc * salaire / 2;
            //if(age >= 50)
            //{
            //    ind += 5 * salaire;
            //}
            //else if(age >= 46)
            //{
            //    ind += 2 * salaire;
            //}

            //Console.WriteLine($"Votre indemnité est de {ind} euros");

            //Switch
            //int mois = 1;
            //switch (mois)
            //{
            //    case 1:
            //        Console.WriteLine("Janvier");
            //        break;
            //    case 2:
            //        Console.WriteLine("Février");
            //        break;
            //    //...
            //    default:
            //        Console.WriteLine("Erreur mois");
            //        break;
            //}
            //int toto = 0;
            //switch (mois)
            //{
            //    case int n when n >= 1 && n <= 3:
            //        Console.WriteLine("hiver "+n);
            //        toto = 1;
            //        break;
            //    case int n when n >= 4 && n <= 6:
            //        Console.WriteLine("printemps");
            //        toto = 2;
            //        break;
            //}

            //Correction de l'exercice 17
            //Console.WriteLine("Liste des boissons disponibles : ");
            //Console.WriteLine("\t 1 - Eau plate");
            //Console.WriteLine("\t 2 - Eau gazeuse");
            //Console.WriteLine("\t 3 - coca");
            //Console.WriteLine("\t 4 - Fanta");
            //Console.Write("Votre choix : ");
            //string choix = Console.ReadLine();
            //string message = "";
            //switch(choix)
            //{
            //    case "1":
            //        message = "eau plate";
            //        break;
            //    case "2":
            //        message = "eau gazeuse";
            //        break;
            //    case "3":
            //        message = "coca";
            //        break;
            //    case "4":
            //        message = "fanta";
            //        break;
            //    default:
            //        message = "mauvais choix ! ";
            //        break;
            //}
            //Console.WriteLine(message);

            //Correction ex 18
            //Console.Write("Merci de saisir l'âge de votre enfant : ");
            //ushort age = Convert.ToUInt16(Console.ReadLine());
            //if (age < 18)
            //{
            //    switch (age)
            //    {
            //        case ushort n when n >= 3 && n <= 6:
            //            Console.WriteLine("Baby");
            //            break;
            //        case ushort n when n >= 7 && n <= 8:
            //            Console.WriteLine("Poussin");
            //            break;
            //        case ushort n when n >= 9 && n <= 10:
            //            Console.WriteLine("Pupille");
            //            break;
            //        case ushort n when n >= 11 && n <= 12:
            //            Console.WriteLine("minime");
            //            break;
            //        case ushort n when n >= 13:
            //            Console.WriteLine("Cadet");
            //            break;
            //            default:
            //            Console.WriteLine("Trop jeune");
            //            break;
            //    }
            //}

            //Suite cours 'Structure d'itération'
            //la boucle for
            //for(int i= 1; i < 100; i=i+3)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 100; i> 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //for(char c='A'; c <= 'z'; c++)
            //{
            //    Console.WriteLine(c);
            //}

            //Correction exercice 21
            //Console.Write("Merci de saisir le nombre de chapitres : ");
            //int chapitre = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Merci de saisir le nombre de parties: ");
            //int partie= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Table des matières : ");
            //for(int i = 1; i <= chapitre; i++)
            //{
            //    Console.WriteLine($"\t Chapitre {i}");
            //    for(int j = 1; j <= partie; j++)
            //    {
            //        Console.WriteLine($"\t\t Partie {i}.{j}");
            //    }
            //}
            //Correction exercice 22
            //Console.Write("Merci de saisir un nombre : ");
            //int nombre = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Table de {nombre}");
            //for(int i=1; i<=10; i++)
            //{
            //    Console.WriteLine($"\t {i} X {nombre} = {i * nombre}");
            //}
            //Correction ex 23
            //Console.Write("Merci de saisir le nombre d'habitant : ");
            //int nombre = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Année de départ : ");
            //int annee = Convert.ToInt32(Console.ReadLine());
            //int anneeInitial = annee;
            //for(int i= 1; i > 0; i++)
            //{
            //    nombre += (int)(nombre * 0.0089F);
            //    annee++;
            //    if (nombre > 120000)
            //    {
            //        break;
            //    }
            //    //else
            //    //{
            //    //    break;
            //    //}
            //}
            //Console.WriteLine($"Il faudra {annee - anneeInitial}, nous serons {annee}");
            //Console.WriteLine($"Il y aura  {nombre} habitants en {annee}");

            //Correction exercice 24
            /*Console.Write("Merci de saisir un nombre : ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= nombre/2 + 1; i++)
            {
                int somme = i;
                string chaine = $"{nombre} = {i}";
                bool found = false;
                for(int j = i + 1; j <= nombre / 2 + 1; j++)
                {
                    somme += j;
                    chaine += $" + {j}";
                    if(somme == nombre)
                    {
                        found = true;
                        break;
                    }
                }
                if(found)
                {
                    Console.WriteLine(chaine);
                }
            }*/
            //Correction exercice 25
            /*Console.Write("Merci de saisir le nombre des notes : ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            int min = 0, max = 0, somme = 0, note;
            for(int i = 1; i <= nombre; i++)
            {
                Console.Write($"Merci de saisir la note N° {i} : ");
                note = Convert.ToInt32(Console.ReadLine());
                somme += note;
                if(i == 1)
                {
                    min = note;
                    max = note;
                }
                else
                {
                    if(note > max)
                    {
                        max = note;
                    }
                    else if(note < min)
                    {
                        min = note;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"La plus grande note est {max}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"La plus petite note est {min}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"La moyenne est de {(double)somme / nombre}");*/

            //Boucle While
            //int i = 10;
            //while (i > 10)
            //{
            //    Console.WriteLine($"{--i}");
            //}
            //Boucle Do While
            /*do
            {
                Console.WriteLine($"{--i}");
            } while (i > 20);*/
            //Correction ex 28
            /*Random random = new Random();
            int nombre = random.Next(1, 51);
            int saisi = 0;
            int nombreEssai = 0;
            do
            {
                //Console.Write("Merci de saisir un nombre : ");
                //saisi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("test en cours...");
                if(nombreEssai == 0)
                {
                    saisi = random.Next(1, 51);
                }                
                nombreEssai++;
                if(saisi < nombre)
                {
                    saisi = random.Next(saisi+1, 51);
                    Console.WriteLine("Plus grand");
                }
                else if(saisi > nombre)
                {
                    saisi = random.Next(1, saisi);
                    Console.WriteLine("Plus petit");
                }
            }while (saisi != nombre);
            Console.WriteLine($"Bravo vous avez gagné en {nombreEssai} Essais");*/
            //Correction exercice 29

            /*int min = 0, max = 0, somme = 0, note;
            int i = 1;
            do
            {
                Console.Write($"Merci de saisir la note N° {i} : ");
                note = Convert.ToInt32(Console.ReadLine());
                if(note != 999)
                {
                    somme += note;
                    if (i == 1)
                    {
                        min = note;
                        max = note;
                    }
                    else
                    {
                        if (note > max)
                        {
                            max = note;
                        }
                        else if (note < min)
                        {
                            min = note;
                        }
                    }
                    i++;
                }
                
                
            } while (note != 999);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"La plus grande note est {max}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"La plus petite note est {min}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"La moyenne est de {(double)somme / (i - 1)}");*/
            //Exercice 30
            //Console.WriteLine("Quelle est l'instruction qui permet de sortir d'une boucle en C# ?");
            //Console.WriteLine("\t a- break");
            //Console.WriteLine("\t b- continue");
            //Console.WriteLine("\t c- exit");
            //Console.WriteLine("\t d- quit");
            //string choix;
            //do
            //{
            //    Console.Write("Entrez votre réponse : ");
            //    choix = Console.ReadLine();
            //    if(choix != "a")
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Il faut réviser !!!!");
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.Write("Nouvel essai ? (o/n) ");
            //        string c = Console.ReadLine();
            //        if(c == "n")
            //        {
            //            break;
            //        }
            //    }
            //} while (choix != "a");
            //if(choix == "a")
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Bravo vous avez gagné un contrat");
            //    Console.ForegroundColor = ConsoleColor.White;
            //}

            //Correction ex 31
            /*string choix;
            int note, somme = 0, nbNotes = 0, min =0 , max =0;
            do
            {
                Console.WriteLine("1 - Saisir les notes");
                Console.WriteLine("2 - La plus grande note");
                Console.WriteLine("3 - La plus petite note");
                Console.WriteLine("4 - La moyenne des notes");
                Console.WriteLine("0 - Quitter");
                Console.Write("Votre choix : ");
                choix = Console.ReadLine();
                Console.Clear();
                switch(choix)
                {
                    case "1":
                        note = 0;
                        somme = 0;
                        nbNotes = 0;
                        min = 0;
                        max = 0;
                        Console.WriteLine("---Saisir les notes---");
                        Console.WriteLine("Merci de saisir 999 pour stoper la saisie");
                        do
                        {
                            Console.Write($"Merci de saisir la note N° {nbNotes + 1} :");
                            note= Convert.ToInt32(Console.ReadLine());
                            if(note >= 0 && note <= 20)
                            {
                                somme += note;
                                nbNotes++;
                                if(nbNotes == 1)
                                {
                                    min = note;
                                    max = note;
                                }
                                else
                                {
                                    if(note > max)
                                    {
                                        max = note;
                                    }
                                    else if(note < min)
                                    {
                                        min = note;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("\t merci de sasir une note entre 0 et 20");
                            }
                        } while (note != 999);
                        break;
                    case "2":
                        Console.WriteLine($"La plus grande note est {max}");
                        break;
                    case "3":
                        Console.WriteLine($"La plus petite note est {min}");

                        break;
                    case "4":
                        Console.WriteLine($"La moyenne est {(double)somme / nbNotes}");

                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }
            } while (choix != "0");*/

            //Cours suite tableau
            /*int[] tab = new int[5];
            tab[1] = 4;
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(tab[i]);
            }
            foreach(int element in tab)
            {
               
                Console.WriteLine(element);
            }*/
            //int[] tab = new int[] { 1, 2, 3 };
            //Correction ex 32
            /*int[] tab = new int[10];
            for(int i= 0; i < tab.Length; i++)
            {
                Console.Write($"Merci de saisir la valeur N° {i + 1} : ");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            string dec = "";
            for(int i= 0; i < tab.Length; i++)
            {
                dec += "\t";
                Console.WriteLine($"{dec} {tab[i]}");
            }*/
            //Correction ex33
            /*int[] tab = new int[26];
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = i+65;
            }
            string dec = "";
            for (int i=0; i < tab.Length; i++)
            {
                dec += " ";
                Console.WriteLine(dec + Convert.ToChar(tab[i]));
            }*/

            //Correction exercice 35
            /*Console.Write("Merci de saisir la taille de l'annuaire : ");
            int taille = Convert.ToInt32(Console.ReadLine());
            string[] contacts = new string[taille];
            int count = 0;
            Console.Clear();
            string choix;
            do
            {
                Console.WriteLine("1 -- Saisir un contact");
                Console.WriteLine("2 -- Afficher les contacts");
                Console.WriteLine("0 -- Quitter");
                choix = Console.ReadLine();
                Console.Clear();
                switch(choix)
                {
                    case "1":
                        if(count < taille)
                        {
                            Console.Write("Merci de saisir le contact : ");
                            contacts[count++] = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Tableau plein");
                        }
                        break;
                    case "2":
                        foreach(string s in contacts)
                        {
                            if(s != null)
                                Console.WriteLine(s);
                        }
                        break;
                }
            } while (choix != "0");*/
            //Correction exercice 36
            /*Console.Write("Merci de saisir la taille des notes : ");
            int taille = Convert.ToInt32(Console.ReadLine());
            int[] notes= new int[taille];
            string choix;
  
            do
            {
                Console.WriteLine("1 - Saisir les notes");
                Console.WriteLine("2 - La plus grande note");
                Console.WriteLine("3 - La plus petite note");
                Console.WriteLine("4 - La moyenne des notes");
                Console.WriteLine("0 - Quitter");
                Console.Write("Votre choix : ");
                choix = Console.ReadLine();
                Console.Clear();
                switch (choix)
                {
                    case "1":
                        for(int i = 0; i < notes.Length; i++)
                        {
                            Console.Write($"Merci de saisir la note N° {i + 1} :");
                            notes[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        
                        break;
                    case "2":
                        int max = notes[0];
                        for(int i=1; i < notes.Length; i++)
                        {
                            if (notes[i] > max)
                            {
                                max = notes[i];
                            }
                        }
                        Console.WriteLine($"La plus grande note est {max}");
                        break;
                    case "3":
                        int min = notes[0];
                        for (int i = 1; i < notes.Length; i++)
                        {
                            if (notes[i] < min)
                            {
                                min = notes[i];
                            }
                        }
                        Console.WriteLine($"La plus petite note est {min}");

                        break;
                    case "4":
                        int somme = 0;
                        for (int i = 0; i < notes.Length; i++)
                        {
                            somme += notes[i];
                        }
                        Console.WriteLine($"La moyenne est {(double)somme / notes.Length}");

                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }
            } while (choix != "0"); */

            //Correction exercice 37
            //string[] mois = new string[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };

            //string dec = "\t";

            //foreach(string m in mois)
            //{
            //    Console.WriteLine($"{dec} {m}");
            //    dec += "\t";
            //}
            /*int[] tab = new int[10];
            Random random = new Random();
            for(int i=0; i<tab.Length; i++)
            {
                tab[i] = random.Next(1,51);
            }
            string dec = "\t";
            foreach (int i in tab)
            {
                Console.WriteLine(dec + i);
                dec += "\t";
            }
            //
            Array.Sort(tab);
            dec = "\t";
            foreach (int i in tab)
            {
                Console.WriteLine(dec + i);
                dec += "\t";
            }*/
            //The great TP
            string[] tab1 = new string[] { "toto", "tata", "titi", "minet" };
            string[] tab2 = new string[tab1.Length];
            int compteur = 0;
            Random r = new Random();
            string choix;
            do
            {
                Console.WriteLine("1-- Effectuer un tirage ");
                Console.WriteLine("2-- Voir la liste des personnes déjà tirées");
                Console.WriteLine("3-- Voir la liste des personnes restantes");
                Console.WriteLine("0-- Quitter");

                Console.Write("Votre choix : ");
                choix = Console.ReadLine();
                Console.Clear();
                switch (choix)
                {
                    case "1":
                        string element;
                        int index;
                        if (compteur < tab1.Length)
                        {
                            do
                            {
                                index = r.Next(0, tab1.Length);
                                element = tab1[index];
                            } while (element == null);
                            Console.WriteLine(element);
                            tab2[compteur++] = element;
                            tab1[index] = null;
                        }
                        else
                        {
                            compteur = 0;
                            for(int i = 0; i < tab1.Length; i++)
                            {
                                tab1[i] = tab2[i];
                                tab2[i] = null;
                            }
                        }
                        break;
                    case "2":
                        foreach(string e in tab2)
                        {
                            if (e != null)
                                Console.WriteLine(e);
                        }
                        break;
                    case "3":
                        foreach (string e in tab1)
                        {
                            if (e != null)
                                Console.WriteLine(e);
                        }
                        break;
                }
            } while (choix != "0");
        }
    }
}