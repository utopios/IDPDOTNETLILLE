using CashRegistryEntityFrameWork.Classes;
using CashRegistryEntityFrameWork.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CashRegistryEntityFrameWork.Repositories
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public override bool Create(Order element)
        {
            _dataContext.Orders.Add(element);
            return _dataContext.SaveChanges() > 0;
        }

        public override Order Find(Func<Order, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Order> FindAll()
        {
            //var orders = _dataContext.Orders/*.Include(p => p.Payment)*/.Include(o => o.Products).ThenInclude(p => p.Product).ToList();
            //orders.ForEach(o =>
            //{
            //    Payment pa = _dataContext.CashPayments.FirstOrDefault(p => p.PaymentId == o.PaymentId);
            //    if (pa == null)
            //    {
            //        pa = _dataContext.CardPayments.FirstOrDefault(p => p.PaymentId == o.PaymentId);
            //    }
            //    o.Payment = pa;
            //});

            //Custom request query with ADO.NET
            var command = _dataContext.Database.GetDbConnection().CreateCommand();
            command.CommandText = "SELECT * FROM order";
            //Custom request query with Model
            var orders = _dataContext.Orders.FromSqlRaw("SELECT Id, PaymentId FROM Order where Id > {0}", 10).ToList();
            return orders;

        }

        public override List<Order> FindAll(Func<Order, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
