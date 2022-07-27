using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Services;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CorrectionPetiteAnnonce.Repositories
{
    public class AnnonceRepository : BaseRepository<Annonce>
    {
        private IHttpContextAccessor _contextAccessor;
        private BaseRepository<Utilisateur> _utilisateurRepository;

        public AnnonceRepository(DataContextService dataContextService, IHttpContextAccessor contextAccessor, BaseRepository<Utilisateur> utilisateurRepository) : base(dataContextService)
        {
            _contextAccessor = contextAccessor;
            _utilisateurRepository = utilisateurRepository;
        }

        public override bool Add(Annonce entity)
        {
            string email = ((ClaimsIdentity)_contextAccessor.HttpContext.User.Identity).FindFirst("username").Value;
            entity.Utilisateur = _utilisateurRepository.Find(u => u.Email == email);
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
