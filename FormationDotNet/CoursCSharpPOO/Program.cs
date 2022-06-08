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
Parent e = new Parent("tt", 10);
//e.Name = "enfant 1";
//e.Number = 10;
Console.WriteLine(e.GetType());
//e.ChildNumber = 33;
//e.Afficher();
((Enfant)e).AfficherEnfant();
