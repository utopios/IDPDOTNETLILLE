using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CorrectionPetiteAnnonce.Controllers
{
    [Route("api/v1/annonce")]
    [ApiController]
    [EnableCors("react")]
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


        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AnnonceDTO annonceDTO)
        {
            Annonce annonce = new Annonce()
            {
                Titre = annonceDTO.Titre,
                Prix = annonceDTO.Prix,
                CategorieId = annonceDTO.CategorieId,
                Description = annonceDTO.Description
            };
            _annonceRepository.Add(annonce);
            return Ok(annonce);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            ClaimsIdentity claimsIdentity = (ClaimsIdentity)HttpContext.User.Identity;
            string email = claimsIdentity.FindFirst("username").Value;
            return Ok(_annonceRepository.FindAll(a => true));
        }

        [HttpPut("{id}/image")]
        [Authorize("police1")]
        public IActionResult PutImage(int id, [FromForm]IFormFile image)
        {
            Annonce annonce = _annonceRepository.Find(a => a.Id == id);
            if(annonce != null)
            {
                annonce.Images.Add(new Image() { Uri = _upload.Upload(image) });
                _annonceRepository.Update();
                return Ok();
            }
            else
            {
                return NotFound();
            }
            
        }
    }

    public record AnnonceDTO(string Titre, decimal Prix, string Description, int CategorieId);
}
