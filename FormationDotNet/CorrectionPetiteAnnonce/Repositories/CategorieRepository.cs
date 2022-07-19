using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Services;

namespace CorrectionPetiteAnnonce.Repositories
{
    public class CategorieRepository : BaseRepository<Categorie>
    {
        public CategorieRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(Categorie entity)
        {
            _dataContextService.Categories.Add(entity);
            return Update() && entity.Id > 0 ;
        }

        public override bool Delete(Categorie entity)
        {
            _dataContextService.Categories.Remove(entity);
            return Update();
        }

        public override Categorie Find(Predicate<Categorie> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Categorie> FindAll(Predicate<Categorie> predicate)
        {
            return _dataContextService.Categories.Where(c => predicate(c)).ToList();
        }
    }
}
