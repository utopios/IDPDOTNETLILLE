using CoursAspNetCoreMVC.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursAspNetCoreMVC.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload

        private IWebHostEnvironment _env;

        private IUpload _upload;
        public UploadController(IWebHostEnvironment env, IUpload upload)
        {
            _env = env;
            _upload = upload;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Upload/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Upload/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Upload/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Upload/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Upload/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Upload/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Upload/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult SubmitForm(IFormFile image)
        {
            //string path = Path.Combine(_env.WebRootPath,"images", image.FileName);
            //Stream stream = new FileStream(path, FileMode.Create);
            //image.CopyTo(stream);
            //stream.Close();
            string chemin = _upload.Upload(image);
            return RedirectToAction("Index");
        }
    }
}
