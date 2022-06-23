using CompteBancaireAdoNet.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireAdoNet.DAO
{
    public class AccountDAO : BaseDAO<Account>
    {
        public AccountDAO()
        {

        }
        public AccountDAO(SqlConnection connection, SqlTransaction transaction) : base(connection, transaction)
        {
        }

        public override Account Get(int id)
        {
            Account account = null;
            int customerId = 0;
            request = "SELECT account_number, total_amount, customer_id from account where id=@id";
            _connection = DataBase.Connection;
            _connection.Open();
            _transaction = _connection.BeginTransaction();
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@id", id));
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                account = new Account()
                {
                    Id = id,
                    TotalAmount = _reader.GetDecimal(1),
                    AccountNumber = _reader.GetInt32(0),
                };
                account.Customer = new CustomerDAO(_connection, _transaction).Get(_reader.GetInt32(2));
            }
            _reader.Close();
            _command.Dispose();
            _transaction.Commit();
            _connection.Close();
            if (account != null)
            {
                account.Operations = new OperationDAO().GetAll(account.Id);
            }
            return account;
        }

        public  Account GetWithAccountNumber(int id)
        {
            Account account = null;
            int customerId = 0;
            request = "SELECT id, total_amount, customer_id from account where account_number=@id";
            _connection = DataBase.Connection;
            _connection.Open();
            _transaction = _connection.BeginTransaction();
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@id", id));
            _command.Transaction = _transaction;
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                account = new Account()
                {
                    Id = _reader.GetInt32(0),
                    TotalAmount = _reader.GetDecimal(1),
                    AccountNumber = id,
                };
                customerId = _reader.GetInt32(2);
            }
            _reader.Close();
            _command.Dispose();
            account.Customer = new CustomerDAO(_connection, _transaction).Get(customerId);

            _connection.Close();
            if (account != null)
            {
                account.Operations = new OperationDAO().GetAll(account.Id);
            }
            return account;
        }

        public override List<Account> GetAll()
        {
            throw new NotImplementedException();
        }

        public override bool Save(Account element)
        {
            request = "INSERT INTO account (account_number, total_amount, customer_id) " +
                "OUTPUT INSERTED.ID values " +
                "(@accountNumber, @totalAmount, @customerId)";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@accountNumber", element.AccountNumber));
            _command.Parameters.Add(new SqlParameter("@totalAmount", element.TotalAmount));
            _command.Parameters.Add(new SqlParameter("@customerId", element.Customer.Id));
            _connection.Open();
            element.Id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            return element.Id > 0;
        }

        public bool Update(Account element)
        {
            request = "update account set total_amount=@totalAmount " +
                "where id=@id";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@totalAmount", element.TotalAmount));
            _command.Parameters.Add(new SqlParameter("@id", element.Id));
            _connection.Open();
            int rowNb = (int)_command.ExecuteNonQuery();
            _command.Dispose();
            _connection.Close();
            return rowNb == 1;
        }
    }
}
