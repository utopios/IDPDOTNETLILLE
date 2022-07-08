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

        public override List<Order> FindAll()
        {
            return _dataContext.Orders.Include(o => o.Products).ThenInclude(p => p.Product).ToList();
        }
    }
}
