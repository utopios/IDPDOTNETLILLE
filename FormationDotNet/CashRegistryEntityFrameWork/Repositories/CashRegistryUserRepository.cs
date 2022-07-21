using CashRegistryEntityFrameWork.Classes;
using CashRegistryEntityFrameWork.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegistryEntityFrameWork.Repositories
{
    public class CashRegistryUserRepository : BaseRepository<CashRegistryUser>
    {
        public CashRegistryUserRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public override bool Create(CashRegistryUser element)
        {
            throw new NotImplementedException();
        }

        

        public override CashRegistryUser Find(Func<CashRegistryUser, bool> predicate)
        {
            return _dataContext.Users.ToList().FirstOrDefault(u => predicate(u));
        }

        public override List<CashRegistryUser> FindAll()
        {
            throw new NotImplementedException();
        }

        public override List<CashRegistryUser> FindAll(Func<CashRegistryUser, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
