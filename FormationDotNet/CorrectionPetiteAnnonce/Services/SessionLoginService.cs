using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Repositories;

namespace CorrectionPetiteAnnonce.Services
{
    public class SessionLoginService : ILogin
    {
        private IHttpContextAccessor _httpContextAccessor;
        private BaseRepository<Utilisateur> _utilisateurRepository;
        public SessionLoginService(IHttpContextAccessor httpContextAccessor, BaseRepository<Utilisateur> utilisateurRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _utilisateurRepository = utilisateurRepository;
        }

        public bool IsLogged()
        {
            string val = _httpContextAccessor.HttpContext.Session.GetString("isLogged");
            return val == "true";
        }

        public bool Login(string username, string password)
        {
            Utilisateur u = _utilisateurRepository.Find(u => u.Email == username && u.Password == password);
            if(u != null)
            {
                _httpContextAccessor.HttpContext.Session.SetString("isLogged", "true");
                return true;
            }
            return false;
        }
    }
}
