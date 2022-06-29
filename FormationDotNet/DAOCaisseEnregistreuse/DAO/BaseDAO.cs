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
        protected SqlConnection _connection;
        protected SqlTransaction _transaction;
        protected SqlCommand _command;
        protected SqlDataReader _reader;
        protected string request;
        protected bool isOpen;
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
