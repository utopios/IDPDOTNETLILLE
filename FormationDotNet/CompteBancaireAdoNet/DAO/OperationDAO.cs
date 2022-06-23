using CompteBancaireAdoNet.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireAdoNet.DAO
{
    public class OperationDAO : BaseDAO<Operation>
    {
        public override Operation Get(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Operation> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Operation> GetAll(int accountId)
        {
            List<Operation> list = new List<Operation>();
            request = "SELECT id, amount, operation_date_time from operation where account_id=@accountId";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@account_id", accountId));
            _connection.Open();
            _reader = _command.ExecuteReader();
            while(_reader.Read())
            {
                Operation o = new Operation(_reader.GetDecimal(1))
                {
                    Id = _reader.GetInt32(0),
                    OperationDateTime = _reader.GetDateTime(2),
                    AccountId = accountId
                };
                list.Add(o);
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return list;
        }

        public override bool Save(Operation element)
        {
            request = "INSERT INTO operation (amount, operation_date_time, account_id) " +
                "OUTPUT INSERTED.ID values " +
                "(@amount, @operationDateTime, @accountId)";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@amount", element.Amount));
            _command.Parameters.Add(new SqlParameter("@operationDateTime", element.OperationDateTime));
            _command.Parameters.Add(new SqlParameter("@accountId", element.AccountId));
            _connection.Open();
            element.Id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            return element.Id > 0;
        }

        //public  bool Save(Operation element, int accountId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
