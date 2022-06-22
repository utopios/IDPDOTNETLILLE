using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireAdoNet.Classes
{
    public class Contact
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phone;

        private List<Email> emails;

        private static SqlConnection _connection;
        private static string request;
        private static SqlCommand _command;
        private static SqlDataReader _reader;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public List<Email> Emails { get => emails; set => emails = value; }

        public Contact(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Emails = new List<Email>();
        }

        public Contact(int id, string firstName, string lastName, string phone) : this(firstName, lastName, phone)
        {
            Id = id;
        }

        public bool Save()
        {
            request = "INSERT INTO contact (first_name, last_name, phone) " +
                "OUTPUT INSERTED.ID values" +
                "(@firstName, @lastName, @phone)";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@firstName", FirstName));
            _command.Parameters.Add(new SqlParameter("@lastName", LastName));
            _command.Parameters.Add(new SqlParameter("@phone", Phone));
            _connection.Open();
            Id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            return Id > 0;
        }

        public bool Update()
        {
            request = "update contact set first_name=@firstName, last_name=@lastName, phone=@phone " +
                "where id=@id"; 
               
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@firstName", FirstName));
            _command.Parameters.Add(new SqlParameter("@lastName", LastName));
            _command.Parameters.Add(new SqlParameter("@phone", Phone));
            _command.Parameters.Add(new SqlParameter("@id", Id));
            _connection.Open();
            int nbRow= _command.ExecuteNonQuery();
            _command.Dispose();
            _connection.Close();
            return nbRow == 1;
        }

        public bool Delete()
        {
            request = "delete from contact where id=@id";

            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);            
            _command.Parameters.Add(new SqlParameter("@id", Id));
            _connection.Open();
            int nbRow = _command.ExecuteNonQuery();
            _command.Dispose();
            _connection.Close();
            return nbRow == 1;
        }

        public static Contact GetContact(int id)
        {
            Contact contact = null;
            request = "SELECT * FROM contact where id=@id";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@id", id));
            _connection.Open();
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                contact = new Contact(_reader.GetInt32(0), _reader.GetString(1), _reader.GetString(2), _reader.GetString(3));
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return contact;
        }

        public static List<Contact> GetContactByPhone(string phone)
        {
            List<Contact> contacts = new List<Contact>();
            request = "SELECT * FROM contact where phone like @phone";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@phone", phone+"%"));
            _connection.Open();
            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                Contact contact = new Contact(_reader.GetInt32(0), _reader.GetString(1), _reader.GetString(2), _reader.GetString(3));
                contacts.Add(contact);
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return contacts;
        }
    }
}
