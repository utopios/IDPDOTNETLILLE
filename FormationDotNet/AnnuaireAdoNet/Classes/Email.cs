using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireAdoNet.Classes
{
    public class Email
    {
        private int id;
        private string mail;
        private int contactId;
        private static SqlConnection _connection;
        private static string request;
        private static SqlCommand _command;
        private static SqlDataReader _reader;

        public int Id { get => id; set => id = value; }
        public string Mail { get => mail; set => mail = value; }
        public int ContactId { get => contactId; set => contactId = value; }

        public bool Save(int contactId)
        {
            return false;
        }

        private bool Delete()
        {
            return false;
        }
        private static List<Email> GetEmails(int contactId)
        {
            return null;
        }
    }
}
