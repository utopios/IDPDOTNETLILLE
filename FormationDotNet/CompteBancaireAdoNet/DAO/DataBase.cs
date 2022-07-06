using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireAdoNet.Classes
{
    public class DataBase
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Desktop\IDP\sgbd.mdf;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection Connection
        {
            get => new SqlConnection(connectionString);
        }
    }
}
