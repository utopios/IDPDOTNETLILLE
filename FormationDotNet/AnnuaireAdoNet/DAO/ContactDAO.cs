using AnnuaireAdoNet.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireAdoNet.DAO
{
    public class ContactDAO : BaseDAO<Contact>
    {
        public override Contact Get(int id)
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

        public override List<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public override bool Save(Contact element)
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
            element.Id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            return element.Id > 0;
        }

        public List<Contact> GetContactByPhone(string phone)
        {
            List<Contact> contacts = new List<Contact>();
            request = "SELECT * FROM contact where phone like @phone";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@phone", phone + "%"));
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
