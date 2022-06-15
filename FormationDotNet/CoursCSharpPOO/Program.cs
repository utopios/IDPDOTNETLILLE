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

//Console.Write("Merci de saisir une decimal > 0 : ");
//string value = Console.ReadLine();
//decimal result = Tools.ParseDecimal(value);

//Console.WriteLine(result);

//Personne p = new Personne();
//try
//{
//    p.Telephone = "1234567890";
//}catch(Exception ex)
//{
//    Console.WriteLine(ex.GetType());
//}finally
//{
//    Console.WriteLine("Bonjour");
//}

//Passage de paramètres
//int a = 10;
//int n = 20;
//int totalInitial = 100;
//Calculatrice.Addition(a, n, ref totalInitial);
//Console.WriteLine(totalInitial);

//int[] tab = new int[] { 1, 2 };
//Calculatrice.Addition(tab);
//foreach(int i in tab)
//{
//    Console.WriteLine(i);
//}

//int b;
//Calculatrice.Initialisation(out b);
//Console.WriteLine(b);

//int age;
//if(int.TryParse(Console.ReadLine(), out age))
//{
//    Console.WriteLine("Votre age est de " + age);
//}
//else
//{
//    Console.WriteLine("Erreur de saisi");
//}

//decimal prix;
//if(Tools.ParseDecimal(Console.ReadLine(), out prix))
//{
//    Console.WriteLine("Le prix est de " + prix);
//}
//else
//{
//    Console.WriteLine("Erreur de saisi");
//}

//Tools.Afficher("frr",10, 30);
//Tools.Afficher("(((",40, 2, 5, 7);

//Console.WriteLine(Calculatrice.Addition(1, 4, 7, 9));
//Console.WriteLine(Calculatrice.Addition(45,54));

//Calculatrice.Calcule(10, 30, Calculatrice.Soustraction);
//Calculatrice.Calcule(10, 30, Tools.Multiplication);
//Calculatrice.Calcule(30, 10, delegate (int a, int b) { return a / b; });
//Calculatrice.Calcule(30, 10, (int a, int b) => { return a / b; });
//Calculatrice.Calcule(30, 10, (a, b) => { return a / b; });
////Une fonction lambda
//Calculatrice.Calcule(30, 10,  (a, b) => a / b);

//Exercice
/*
 Modifier la classe pile en y ajoutant une méthode rechercher 
qui accepte comme paramètre la méthode de recherche.
 */
//Pile<string> pile = new Pile<string>(3);
//pile.Empiler("toto");
//pile.Empiler("tata");

//string element = pile.SearchElement(e => e == "titi");
//Console.WriteLine(element);

//List<string> liste = new List<string>() { "toto", "tata", "titi" };

//string element = liste.Find(e => e == "toto");
//Console.WriteLine(element);

//Utilisation des events

Moto moto = new Moto();
moto.Promotion += Tools.EnvoieMail;
moto.Promotion += Tools.EnvoieSMS;
moto.Prix = 3000;
int count = 0;
string choix;
do
{
    Console.Write("Une promo ? ");
    choix = Console.ReadLine();
    if (choix == "oui")
    {
        count++;
        decimal.TryParse(Console.ReadLine(), out decimal montant);
        moto.Reduction(montant);
        if(count ==2)
        {
            moto.Promotion -= Tools.EnvoieSMS;
        }
    }
} while (choix != "0");