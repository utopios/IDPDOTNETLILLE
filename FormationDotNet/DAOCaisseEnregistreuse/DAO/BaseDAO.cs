using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOCaisseEnregistreuse.DAO
{
    public abstract class BaseDAO <T>
    {
        protected static SqlConnection _connection;
        protected static SqlTransaction _transaction;
        protected static SqlCommand _command;
        protected static SqlDataReader _reader;
        protected static string request;

        public BaseDAO()
        {

        }
        public BaseDAO(SqlConnection connection, SqlTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }
        public abstract bool Save(T element);
        public abstract T Get(int id);
        public abstract List<T> GetAll();
    }
}
