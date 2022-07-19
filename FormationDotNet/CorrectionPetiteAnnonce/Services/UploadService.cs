using CorrectionPetiteAnnonce.Interfaces;

namespace CorrectionPetiteAnnonce.Services
{
    public class UploadService : IUpload
    {
        private IWebHostEnvironment _env;

        public UploadService(IWebHostEnvironment env)
        {
            _env = env;
        }
        public string Upload(IFormFile file)
        {
            string path = Path.Combine(_env.WebRootPath, "images", file.FileName);
            Stream stream = new FileStream(path, FileMode.Create);
            file.CopyTo(stream);
            stream.Close();
            return "images/" + file.FileName;
        }
    }
}
