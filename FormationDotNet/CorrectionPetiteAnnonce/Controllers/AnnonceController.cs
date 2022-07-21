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
        private ILogin _login;
        public AnnonceController(BaseRepository<Categorie> categorieRepository, BaseRepository<Annonce> annonceRepository, IUpload upload, ILogin login)
        {
            _categorieRepository = categorieRepository;
            _annonceRepository = annonceRepository;
            _upload = upload;
            _login = login;
        }

        public IActionResult Index()
        {
            return View(_annonceRepository.FindAll(a => true));
        }

        public IActionResult Form()
        {
            if (_login.IsLogged())
                return View(_categorieRepository.FindAll(c => true));
            else
                return RedirectToAction("Index", "Login");
        }

        [HttpPost]
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

        public IActionResult Detail(int id)
        {
            Annonce annonce = _annonceRepository.Find(a => a.Id == id);
            return View(annonce);
        }
    }
}
