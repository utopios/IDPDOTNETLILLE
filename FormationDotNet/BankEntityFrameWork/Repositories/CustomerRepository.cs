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
            throw new NotImplementedException();
        }

        public override bool Delete(Customer element)
        {
            throw new NotImplementedException();
        }

        public override Customer Find(Predicate<Customer> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Customer> FindAll(Predicate<Customer> predicate)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Customer element)
        {
            throw new NotImplementedException();
        }
    }
}
