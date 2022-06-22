using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireAdoNet.Classes
{
    public class DataBase
    {
        private static string connectionString;

        public static SqlConnection Connection
        {
            get => new SqlConnection(connectionString);
        }
    }
}
