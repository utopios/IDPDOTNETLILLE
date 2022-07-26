using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorrectionPetiteAnnonce.Controllers
{
    [Route("api/v1/annonce")]
    [ApiController]
    public class AnnonceAPIController : ControllerBase
    {
        private BaseRepository<Categorie> _categorieRepository;
        private BaseRepository<Annonce> _annonceRepository;
        private IUpload _upload;
        public AnnonceAPIController(BaseRepository<Categorie> categorieRepository, BaseRepository<Annonce> annonceRepository, IUpload upload)
        {
            _categorieRepository = categorieRepository;
            _annonceRepository = annonceRepository;
            _upload = upload;           
        }
    }
}
