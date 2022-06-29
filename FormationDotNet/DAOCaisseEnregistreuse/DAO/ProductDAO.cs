using DAOCaisseEnregistreuse.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOCaisseEnregistreuse.DAO
{
    public class ProductDAO : BaseDAO<Product>
    {
        public override Product Get(int id)
        {
            Product product = null;
            request = "SELECT title, price, stock FROM product where id=@id";
            //isOpen = _connection.State == ConnectionState.Open;
            //if(!isOpen)
            //{
            //    _connection = DataBase.Connection;
            //    _connection.Open();
            //    _transaction = _connection.BeginTransaction();
            //}
            OpenConnection();
            _command = new SqlCommand(request, _connection);
            _command.Transaction = _transaction;
            _command.Parameters.Add(new SqlParameter("@id", id));
            _reader = _command.ExecuteReader();
            if(_reader.Read())
            {
                product = new Product(id, _reader.GetString(0), _reader.GetDecimal(1), _reader.GetInt32(2));
            }
            _reader.Close();
            _command.Dispose();
            CloseConnection();
            return product;
        }

        public override List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public override bool Save(Product element)
        {
            request = "INSERT INTO product (title, price, stock) " +
                "OUTPUT INSERTED.ID values" +
                "(@title,@price,@stock)";
            OpenConnection();
            _command = new SqlCommand(request, _connection);
            _command.Transaction = _transaction;
            _command.Parameters.Add(new SqlParameter("@title", element.Title));
            _command.Parameters.Add(new SqlParameter("@price", element.Price));
            _command.Parameters.Add(new SqlParameter("@stock", element.Stock));
            element.Id = (int)_command.ExecuteScalar();
            _command.Dispose();
            CloseConnection();
            return element.Id > 0;
        }
    }
}
