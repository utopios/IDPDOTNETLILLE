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
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public override bool Create(Product element)
        {
            _dataContext.Products.Add(element);
            return _dataContext.SaveChanges() > 0;
        }

        public override Product Find(Func<Product, bool> predicate)
        {
            return _dataContext.Products.FirstOrDefault(p => predicate(p));
        }

        public override List<Product> FindAll()
        {
            return _dataContext.Products.ToList();
        }

        public override List<Product> FindAll(Func<Product, bool> predicate)
        {
            //A revoir
            return _dataContext.Products.ToList().Where(p => predicate(p)).ToList();
        }
    }
}
