using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Services;

namespace CorrectionPetiteAnnonce.Repositories
{
    public class UtilisateurRepository : BaseRepository<Utilisateur>
    {
        public UtilisateurRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(Utilisateur entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Utilisateur entity)
        {
            throw new NotImplementedException();
        }

        public override Utilisateur Find(Func<Utilisateur, bool> predicate)
        {
            return _dataContextService.Utilisateurs.ToList().FirstOrDefault(u => predicate(u));
        }

        public override List<Utilisateur> FindAll(Func<Utilisateur, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
