using CoursCSharpPOO.Classes;

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
Maison<Enfant> maisonEnfant = new Maison<Enfant>();
maisonEnfant.Entrer(new Enfant("t", 10));

Maison<LePendu> maisonLePendu = new Maison<LePendu>();
maisonLePendu.Entrer(new LePendu());