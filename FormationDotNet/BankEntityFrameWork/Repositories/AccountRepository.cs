using BankEntityFrameWork.Classes;
using BankEntityFrameWork.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEntityFrameWork.Repositories
{
    public class AccountRepository : BaseRepository<Account>
    {
        public AccountRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public override bool Create(Account element)
        {
            _dataContext.Accounts.Add(element);
            return _dataContext.SaveChanges() > 0;
        }

        public override bool Delete(Account element)
        {
            throw new NotImplementedException();
        }

        public override Account Find(Predicate<Account> predicate)
        {
            return _dataContext.Accounts.Include(p => p.Customer).Include(c => c.Operations).FirstOrDefault((e) => predicate(e));
        }

        public override List<Account> FindAll(Predicate<Account> predicate)
        {
            return _dataContext.Accounts.Include(p=>p.Customer).Include(c => c.Operations).Where((e) => predicate(e)).ToList();
        }

        public override bool Update()
        {
            return _dataContext.SaveChanges() > 0;
        }
    }
}
