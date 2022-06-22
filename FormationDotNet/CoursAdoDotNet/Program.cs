// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;



//Ado.net Connexion à une base de données sql server
string connectionString = @"Data Source=(LocalDb)\cousDotNet;Integrated Security=True"; 
SqlConnection connection = new SqlConnection(connectionString);
//string nom = "abadi", 
//    prenom = "ihab", 
//    email = "ihab@utopios.net", 
//    telephone = "01010101", 
//    titre = "Mr";
//string sql = "INSERT INTO personne (titre, nom, prenom, email, telephone)" +
//    " values (@titre, @nom, @prenom, @email, @telephone)";
//SqlCommand cmd = new SqlCommand(sql, connection);
//cmd.Parameters.Add(new SqlParameter("@titre", titre));
//cmd.Parameters.Add(new SqlParameter("@prenom", prenom));
//cmd.Parameters.Add(new SqlParameter("@nom", nom));
//cmd.Parameters.Add(new SqlParameter("@telephone", telephone));
//cmd.Parameters.Add(new SqlParameter("@email", email));

////Se connecter
//connection.Open();

////Executer la commande
////1 - en utilisant la méthode nonQuery
//int nbLigne = cmd.ExecuteNonQuery();

////Libération des ressources
//cmd.Dispose();
////Fermer la connexion
//connection.Close();

//Console.WriteLine(nbLigne);

//Ecrire un programme qui demande à l'utilisateur de saisir
//titre produit, prix et stock et les ajoute dans une table produit

//Correction

//string request = "CREATE TABLE produit (" +
//    "id int PRIMARY KEY IDENTITY(1,1)," +
//    "titre varchar(100) not null," +
//    "prix decimal not null," +
//    "stock int not null"+
//    ")";
//SqlCommand command = new SqlCommand(request, connection);
//connection.Open();
//try
//{
//    command.ExecuteNonQuery();
//    Console.WriteLine("table créée");
//}catch(Exception ex)
//{
//    Console.WriteLine("Table existe");
//}
//finally
//{
//    command.Dispose();
//}
//Console.Write("Merci de saisir le titre du produit : ");
//string titre = Console.ReadLine();
//Console.Write("Merci de saisir le prix du produit : ");
//decimal prix = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Merci de saisir le stock du produit : ");
//int stock = Convert.ToInt32(Console.ReadLine());

//request = "INSERT INTO produit (titre, prix, stock) " +
//    "OUTPUT INSERTED.id " +
//    "values (@titre, @prix, @stock)";

//command = new SqlCommand(request, connection);
//command.Parameters.Add(new SqlParameter("@titre", titre));
//command.Parameters.Add(new SqlParameter("@prix", prix));
//command.Parameters.Add(new SqlParameter("@stock", stock));

////int nbLigne = command.ExecuteNonQuery();
//int id = (int)command.ExecuteScalar();
////Console.WriteLine(nbLigne);
//Console.WriteLine(id);
//command.Dispose();
//connection.Close();


//Requete de lecture
string request = "SELECT * FROM produit";
SqlCommand command = new SqlCommand(request, connection);
connection.Open();
SqlDataReader reader = command.ExecuteReader();
while(reader.Read())
{
    Console.WriteLine($"id {reader.GetInt32(0)}, titre {reader.GetString(1)}");
}
reader.Close();
command.Dispose();
connection.Close();