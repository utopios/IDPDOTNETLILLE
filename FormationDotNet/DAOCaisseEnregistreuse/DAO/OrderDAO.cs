using DAOCaisseEnregistreuse.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOCaisseEnregistreuse.DAO
{
    public class OrderDAO : BaseDAO<Order>
    {
        public OrderDAO(SqlConnection connection, SqlTransaction transaction) : base(connection, transaction)
        {

        }

        public override Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public override bool Save(Order element)
        {
            bool result = false;
            OpenConnection();
            try
            {
                //Enregistrer la commande
                request = "INSERT INTO order (total) OUTPUT INSERTED.ID values" +
                "(@total)";
                _command = new SqlCommand(request, _connection);
                _command.Transaction = _transaction;
                _command.Parameters.Add(new SqlParameter("@total", element.Total));
                element.Id = (int)_command.ExecuteScalar();
                _command.Dispose();

                //Enregistrer le paiement et mettre à jour le sock
                
                request = "INSERT INTO payment (total, payment_date, type) OUTPUT INSERTED.ID (@total, @payment_date, @type)";
                _command = new SqlCommand(request, _connection);
                _command.Transaction = _transaction;
                _command.Parameters.Add(new SqlParameter("@total", element.Total));
                _command.Parameters.Add(new SqlParameter("@payment_date", element.Payment.PaymentDate));
                _command.Parameters.Add(new SqlParameter("@type", element.Payment.GetType().ToString());
                element.Payment.Id = (int)_command.ExecuteScalar();
                _command.Dispose();

                if(element.Payment is CardPayment cardPayment)
                {
                    request = "INSERT INTO card_payment (payment_id) values (@payment_id)";
                    _command = new SqlCommand(request, _connection);
                    _command.Transaction = _transaction;
                    _command.Parameters.Add(new SqlParameter("@payment_id", element.Payment.Id));
                    _command.ExecuteNonQuery();
                    _command.Dispose();
                }
                else if (element.Payment is CashPayment cashPayment)
                {
                    request = "INSERT INTO cash_payment (payment_id, change) values (@payment_id, @change)";
                    _command = new SqlCommand(request, _connection);
                    _command.Transaction = _transaction;
                    _command.Parameters.Add(new SqlParameter("@payment_id", element.Payment.Id));
                    _command.Parameters.Add(new SqlParameter("@change", cashPayment.Change));
                    _command.ExecuteNonQuery();
                    _command.Dispose();
                }

                //Enregistrer les produits de commande

                foreach (ProductOrder p in element.Products)
                {
                    request = "INSERT INTO product_order (product_id, order_qty, qty)" +
                        "values(@product_id, @order_qty, @qty);" +
                        "update product set stock=stock-@qty where id=@product_id;";
                    _command = new SqlCommand(request, _connection);
                    _command.Transaction = _transaction;
                    _command.Parameters.Add(new SqlParameter("@product_id", p.Product.Id));
                    _command.Parameters.Add(new SqlParameter("@order_qty", element.Id));
                    _command.Parameters.Add(new SqlParameter("@qty", p.Qty));
                    //_command.Parameters.Add(new SqlParameter("@stock",p.Product.Stock-p.Qty));
                    _command.ExecuteNonQuery();
                    _command.Dispose();
                }

                result = true;
            }catch(Exception ex)
            {

            }
            return result;                     
        }
    }
}
