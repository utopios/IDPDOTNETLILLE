﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOCaisseEnregistreuse.DAO
{
    public class DataBase
    {
        private static string connectionString = @"Data Source=(LocalDb)\cousDotNet;Integrated Security=True";

        public static SqlConnection Connection
        {
            get => new SqlConnection(connectionString);
        }
    }
}
