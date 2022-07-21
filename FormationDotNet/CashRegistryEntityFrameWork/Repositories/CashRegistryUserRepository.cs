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

        public override List<CashRegistryUser> FindAll()
        {
            throw new NotImplementedException();
        }

        public override List<CashRegistryUser> FindAll(Predicate<CashRegistryUser> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
