using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CorrectionPetiteAnnonce.Controllers
{
    public class AnnonceController : Controller
    {
        private BaseRepository<Categorie> _categorieRepository;
        private BaseRepository<Annonce> _annonceRepository;
        private IUpload _upload;
        public AnnonceController(BaseRepository<Categorie> categorieRepository, BaseRepository<Annonce> annonceRepository, IUpload upload)
        {
            _categorieRepository = categorieRepository;
            _annonceRepository = annonceRepository;
            _upload = upload;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View(_categorieRepository.FindAll(c=>true));
        }

        public IActionResult SubmitForm(Annonce annonce, IFormFile[] images)
        {
            foreach(IFormFile image in images)
            {
                Image img = new Image()
                {
                    Uri = _upload.Upload(image)
                };
                annonce.Images.Add(img);
            }
            _annonceRepository.Add(annonce);
            return RedirectToAction("Index");
        }
    }
}
