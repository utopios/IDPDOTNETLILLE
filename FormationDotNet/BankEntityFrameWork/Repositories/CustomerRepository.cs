using BankEntityFrameWork.Classes;
using BankEntityFrameWork.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEntityFrameWork.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public override bool Create(Customer element)
        {
            _dataContext.Customers.Add(element);
            return _dataContext.SaveChanges() > 0;
        }

        public override bool Delete(Customer element)
        {
            _dataContext.Customers.Remove(element);
            return _dataContext.SaveChanges() > 0;
        }

        public override Customer Find(Predicate<Customer> predicate)
        {
            return _dataContext.Customers.FirstOrDefault(c => predicate(c));
        }

        public override List<Customer> FindAll(Predicate<Customer> predicate)
        {
            return _dataContext.Customers.Where(c => predicate(c)).ToList();
        }

        public override bool Update()
        {
            return _dataContext.SaveChanges() > 0;
        }
    }
}
