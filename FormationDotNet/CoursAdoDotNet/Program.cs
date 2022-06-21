// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;



//Ado.net Connexion à une base de données sql server
string connectionString = @"Data Source=(LocalDb)\cousDotNet;Integrated Security=True"; 
SqlConnection connection = new SqlConnection(connectionString);
string nom = "abadi", 
    prenom = "ihab", 
    email = "ihab@utopios.net", 
    telephone = "01010101", 
    titre = "Mr";
string sql = "INSERT INTO personne (titre, nom, prenom, email, telephone)" +
    " values (@titre, @nom, @prenom, @email, @telephone)";
SqlCommand cmd = new SqlCommand(sql, connection);
cmd.Parameters.Add(new SqlParameter("@titre", titre));
cmd.Parameters.Add(new SqlParameter("@prenom", prenom));
cmd.Parameters.Add(new SqlParameter("@nom", nom));
cmd.Parameters.Add(new SqlParameter("@telephone", telephone));
cmd.Parameters.Add(new SqlParameter("@email", email));

//Se connecter
connection.Open();

//Executer la commande
//1 - en utilisant la méthode nonQuery
int nbLigne = cmd.ExecuteNonQuery();

//Libération des ressources
cmd.Dispose();
//Fermer la connexion
connection.Close();

Console.WriteLine(nbLigne);