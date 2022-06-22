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
            request = "INSERT INTO email (mail, contact_id) " +
                "OUTPUT INSERTED.ID values" +
                "(@mail, @contactId)";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@mail", Mail));
            _command.Parameters.Add(new SqlParameter("@contactId", contactId));
            _connection.Open();
            Id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            return Id > 0;
        }

        private bool Delete()
        {
            request = "delete from email where id=@id";

            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@id", Id));
            _connection.Open();
            int nbRow = _command.ExecuteNonQuery();
            _command.Dispose();
            _connection.Close();
            return nbRow == 1;
        }
        public static List<Email> GetEmails(int contactId)
        {
            List<Email> emails = new List<Email>();
            request = "SELECT * FROM email where contact_id=@contactId";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@contactId", contactId));
            _connection.Open();
            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                Email email = new Email()
                {
                    Id = _reader.GetInt32(0),
                    Mail = _reader.GetString(1)
                };
                emails.Add(email);
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return emails;
        }
    }
}
