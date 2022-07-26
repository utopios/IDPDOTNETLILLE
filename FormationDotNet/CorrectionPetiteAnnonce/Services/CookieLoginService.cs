using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Repositories;

namespace CorrectionPetiteAnnonce.Services
{
    public class CookieLoginService : ILogin
    {
        private  IHttpContextAccessor _contextAccessor;
        private BaseRepository<Utilisateur> _utilisateurRepository;

        public CookieLoginService(IHttpContextAccessor contextAccessor, BaseRepository<Utilisateur> utilisateurRepository)
        {
            _contextAccessor = contextAccessor;
            _utilisateurRepository = utilisateurRepository;
        }

        public bool IsLogged()
        {
            string test = _contextAccessor.HttpContext.Request.Cookies["logged"];
            return test == "true";
        }

        public bool Login(string username, string password)
        {
            Utilisateur u = _utilisateurRepository.Find(u => u.Email == username && u.Password == password);
            if(u != null)
            {
                _contextAccessor.HttpContext.Response.Cookies.Append("logged", "true");
                return true;
            }
            return false;
        }

        public string Login(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
