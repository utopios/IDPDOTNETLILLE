using CoursCSharpPOO.Classes;
using CoursCSharpPOO.Interface;

//Création d'une personne à partir de la classe personne
//Personne p = new Personne();
////p.prenom = "ihab";
////p.nom = "abadi";
////p.SetNom("abadi");
////p.SetPrenom("ihab");
//p.Nom = "abadi";
////Personne p = new Personne("Abadi", "Ihab");
////Console.WriteLine($"{p.nom} {p.prenom}");
//p.Afficher();

////Pour accéder à un element statique
//Personne.Nombre = 34;
//Console.WriteLine(Personne.Nombre);
//IHMSalarie ihm = new IHMSalarie();
//ihm.Demarrer();
//IHMPendu pendu = new IHMPendu();
//pendu.Jouer();

//Cours héritage
//Parent e = new Enfant("tt", 10);
////e.Name = "enfant 1";
////e.Number = 10;
//Console.WriteLine(e.GetType());
////e.ChildNumber = 33;
//e.Afficher();

//((Enfant)e).AfficherEnfant();
//Pour le cast entre objets
//Enfant enfant = (Enfant)e;
//Enfant enfant = e as Enfant;
//if(enfant != null)
//    Console.WriteLine(enfant.GetType());

//if(e is Enfant enfant)
//{
//    Console.WriteLine(enfant.GetType());
//}

//Parent[] elements = new Parent[2];
//elements[0] = new EnfantA("test A", 10);
//elements[1] = new EnfantB("test B", 10);
//foreach(Parent e in elements)
//{
//    e.Afficher();
//    if(e is EnfantA ea)
//    {
//        ea.AfficherA();
//    }
//    else if(e is EnfantB eb)
//    {
//        eb.AfficherB();
//    }
//    Console.WriteLine(e.GetType());
//}

//IHMSalarieHeritage ihm = new IHMSalarieHeritage();
//ihm.Demarrer();

//Générique
//Maison<Enfant> maisonEnfant = new Maison<Enfant>();
//maisonEnfant.Entrer(new Enfant("t", 10));

//Maison<LePendu> maisonLePendu = new Maison<LePendu>();
//maisonLePendu.Entrer(new LePendu());

//Cas d'utilisation
//Pile<string> pileS = new Pile<string>(3);
//pileS.Empiler("Toto");
//pileS.Empiler("Tata");
//pileS.Empiler("Titi");

//pileS.Depiler();

//string element = pileS.GetElement(2);
//Console.WriteLine(element);

//Liste
//List<string> liste = new List<string>();
//liste.Add("toto");
//liste.Add("tata");
//liste.Remove("toto");
//Console.WriteLine(liste.Count);

//Dictionnaire
//Dictionary<string, Enfant> dico = new Dictionary<string, Enfant>();
//dico.Add("key1", new Enfant("enfant key1", 10));

////Parccourir les clés d'un dico
//foreach(string key in dico.Keys)
//{
//    Console.WriteLine(dico[key]);
//}

////Ou les valeurs
//foreach(Enfant e in dico.Values)
//{
//    Console.WriteLine(e);
//}

//IAvancer a = new Salarie("", "", "", "", 1000);
//IAvancer b = new Maison<int>();
//List<IAvancer> liste = new List<IAvancer>();
//liste.Add(a);
//liste.Add(b);
//Voiture laguna = new Voiture("Renault", "Laguna", 30);
//Console.WriteLine(laguna); 
//laguna.Demarrer(); 
//laguna.Rouler(25); 
//Console.WriteLine(laguna);

//Gestion des exceptions
//try
//{
//    Console.Write("Merci de saisir un nombre ");
//    int nb = Convert.ToInt32(Console.ReadLine());
//    object o = new object();
//    Enfant e = (Enfant)o;
//    e.AfficherEnfant();
//}
//catch(FormatException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch(InvalidCastException ex)
//{
//    Console.WriteLine("Erreur  cast "+ ex.Message);
//}

//Ecrire une méthode qui permet de gérér les exceptions
//de conversion entre une chaine de caractère et une décimal.

Console.Write("Merci de saisir une decimal > 0 : ");
string value = Console.ReadLine();
decimal result = Tools.ParseDecimal(value);

Console.WriteLine(result);