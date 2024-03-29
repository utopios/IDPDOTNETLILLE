﻿using CompteBancaireAdoNet.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireAdoNet.DAO
{
    public class CustomerDAO : BaseDAO<Customer>
    {
        public CustomerDAO()
        {

        }
        public CustomerDAO(SqlConnection connection, SqlTransaction transaction) : base(connection, transaction)
        {
        }

        public override Customer Get(int id)
        {
            Customer customer = null;
            request = "SELECT first_name, last_name, phone from customer where id=@id";
            bool isOpen = _connection.State == ConnectionState.Open;
            _connection =(isOpen) ? _connection : DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            if(isOpen && _transaction != null)
            {
                _command.Transaction = _transaction;
            }
            _command.Parameters.Add(new SqlParameter("@id", id));
            if(!isOpen)
                _connection.Open();
            _reader = _command.ExecuteReader();
            if(_reader.Read())
            {
                customer = new Customer(_reader.GetString(2), _reader.GetString(0), _reader.GetString(1))
                {
                    Id = id
                };
            }
            _reader.Close();
            _command.Dispose();
            if(!isOpen)
                _connection.Close();
            return customer;
        }

        public override List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public override bool Save(Customer element)
        {
            request = "INSERT INTO customer (first_name, last_name, phone) " +
                "OUTPUT INSERTED.ID values " +
                "(@firstName, @lastName, @phone)";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@firstName", element.FirstName));
            _command.Parameters.Add(new SqlParameter("@lastName", element.LastName));
            _command.Parameters.Add(new SqlParameter("@phone", element.Phone));
            _connection.Open();
            element.Id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            return element.Id > 0;
        }
    }
}
