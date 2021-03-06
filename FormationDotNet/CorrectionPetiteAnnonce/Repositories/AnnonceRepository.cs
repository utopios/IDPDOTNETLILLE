using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Services;
using Microsoft.EntityFrameworkCore;

namespace CorrectionPetiteAnnonce.Repositories
{
    public class AnnonceRepository : BaseRepository<Annonce>
    {
        public AnnonceRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(Annonce entity)
        {
            _dataContextService.Annonces.Add(entity);
            return Update() && entity.Id > 0;
        }

        public override bool Delete(Annonce entity)
        {
            _dataContextService.Annonces.Remove(entity);
            return Update();
        }

        public override Annonce Find(Func<Annonce, bool> predicate)
        {
            return _dataContextService.Annonces
                .Include(a => a.Images)
                .Include(a => a.Categorie)
                .ToList().FirstOrDefault(a => predicate(a));
        }

        public override List<Annonce> FindAll(Func<Annonce, bool> predicate)
        {
            return _dataContextService.Annonces
                .Include(a => a.Images)
                .Include(a => a.Categorie).
                ToList().Where(a => predicate(a)).ToList();
        }
    }
}
