using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Repositories;
using Newtonsoft.Json;

namespace CorrectionPetiteAnnonce.Services
{
    public class FavorisService
    {
        private IHttpContextAccessor _contextAccessor;
        private BaseRepository<Annonce> _annonceRepository;

        public FavorisService(IHttpContextAccessor contextAccessor, BaseRepository<Annonce> annonceRepository)
        {
            _contextAccessor = contextAccessor;
            _annonceRepository = annonceRepository;
        }

        public bool IsInFavoris(int id)
        {
            List<int> favorisInt = GetFavorisInSession();
            if(favorisInt != null)
            {
                return favorisInt.Contains(id);
            }
            return false;
        }

        public bool AddToFavoris(int id)
        {
            var favorisInt = GetFavorisInSession();
            if(!favorisInt.Contains(id))
            {
                favorisInt.Add(id);
                return true;
            }
            return false;
        }

        public bool RemoveFromFavoris(int id)
        {
            var favorisInt = GetFavorisInSession();
            if (favorisInt.Contains(id))
            {
                favorisInt.Remove(id);
                return true;
            }
            return false;
        }

        public List<Annonce> GetFavoris()
        {
            List<Annonce> annonces = new List<Annonce>();
            var favorisInt = GetFavorisInSession();
            foreach(int i in favorisInt)
            {
                annonces.Add(_annonceRepository.Find(a => a.Id == i));
            }
            return annonces;
        }

        private List<int> GetFavorisInSession()
        {
            string favorisString = _contextAccessor.HttpContext.Session.GetString("favoris");
            try
            {
                List<int> list = JsonConvert.DeserializeObject<List<int>>(favorisString);
                return list;
            }catch(Exception ex)
            {
                return null;
            }
        }


    }
}
