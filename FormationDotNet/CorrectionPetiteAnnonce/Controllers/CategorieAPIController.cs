using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorrectionPetiteAnnonce.Controllers
{
    [Route("api/v1/Categorie")]
    [ApiController]
    public class CategorieAPIController : ControllerBase
    {
        private BaseRepository<Categorie> _categorieRepository;

        public CategorieAPIController(BaseRepository<Categorie> categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }

        [HttpPost]
        public IActionResult Post(Categorie categorie)
        {
            _categorieRepository.Add(categorie);
            return Ok(categorie);
        }
    }
}
