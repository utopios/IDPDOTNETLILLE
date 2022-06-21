// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;



//Ado.net Connexion à une base de données sql server
string connectionString = @"Data Source=(LocalDb)\cousDotNet;Integrated Security=True"; 
SqlConnection connection = new SqlConnection(connectionString);

string sql = "INSERT INTO personne (titre, nom, prenom, email, telephone)" +
    " values ('Mr', 'sql', 'sql', 'sql', 'sql')";
SqlCommand cmd = new SqlCommand(sql, connection);
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