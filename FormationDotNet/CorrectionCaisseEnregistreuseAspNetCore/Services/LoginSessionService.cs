using CashRegistryEntityFrameWork.Classes;
using CashRegistryEntityFrameWork.Repositories;
using CorrectionCaisseEnregistreuseAspNetCore.Interfaces;

namespace CorrectionCaisseEnregistreuseAspNetCore.Services
{
    public class LoginSessionService : ILogin
    {
        private IHttpContextAccessor _httpContextAccessor;
        private BaseRepository<CashRegistryUser> _utilisateurRepository;
        public LoginSessionService(IHttpContextAccessor httpContextAccessor, BaseRepository<CashRegistryUser> utilisateurRepository)
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
            CashRegistryUser u = _utilisateurRepository.Find(u => u.Username == username && u.Password == password);
            if (u != null)
            {
                _httpContextAccessor.HttpContext.Session.SetString("isLogged", "true");
                return true;
            }
            return false;
        }
    }
}
