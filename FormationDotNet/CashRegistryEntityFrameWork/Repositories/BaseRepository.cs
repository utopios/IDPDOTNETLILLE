using CashRegistryEntityFrameWork.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegistryEntityFrameWork.Repositories
{
    public abstract class BaseRepository<T>
    {
        protected DataContext _dataContext;

        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public abstract bool Create(T element);

        public bool Update()
        {
            return _dataContext.SaveChanges() > 0;
        }

        public abstract List<T> FindAll();
    }
}
