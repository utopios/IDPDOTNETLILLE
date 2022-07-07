// See https://aka.ms/new-console-template for more information
using CoursEntityFrameWorkCore;

//Personne p = new Personne()
//{
//    Name = "toto",
//    Age = 30
//};
DataContext d = new DataContext();
//Enregistrer la personne dans la table
//d.Personnes.Add(p);
//d.SaveChanges();

//Pour récupérer les données

//List<Personne> list = d.Personnes.ToList();

//Console.WriteLine(list.Count);

//Personne p = d.Personnes.Find(1);
Personne p = d.Personnes.FirstOrDefault(p=> p.Name == "toto");
//List<Personne> list = d.Personnes.Where(p => p.Name == "toto").ToList();

p.Name = "tata";

d.SaveChanges();

Console.WriteLine(p);