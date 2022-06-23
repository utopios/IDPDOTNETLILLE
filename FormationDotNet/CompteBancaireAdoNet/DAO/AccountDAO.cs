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
        public override Account Get(int id)
        {
            Account account = null;
            int customerId = 0;
            request = "SELECT account_number, total_amount, customer_id from account where id=@id";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@id", id));
            _connection.Open();
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                account = new Account()
                {
                    Id = id,
                    TotalAmount = _reader.GetDecimal(1),
                    AccountNumber = _reader.GetInt32(0),
                };
                customerId = _reader.GetInt32(2);
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            if (account != null)
            {
                account.Customer = new CustomerDAO().Get(customerId);
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
    }
}
