using CorrectionPetiteAnnonce.Services;

namespace CorrectionPetiteAnnonce.Repositories
{
    public abstract class BaseRepository<T>
    {
        protected DataContextService _dataContextService;
        public BaseRepository(DataContextService dataContextService)
        {
            _dataContextService = dataContextService;
        }
        public abstract bool Add(T entity);
        
        public abstract bool Delete(T entity);

        public abstract T Find(Predicate<T> predicate);
        
        public abstract List<T> FindAll(Predicate<T> predicate);

        public bool Update()
        {
            return _dataContextService.SaveChanges() > 0;
        }
    }
}
