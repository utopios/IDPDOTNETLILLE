using Azure.Identity;
using Azure.Storage.Blobs;
using CorrectionPetiteAnnonce.Interfaces;

namespace CorrectionPetiteAnnonce.Services
{
    public class UploadAzureService : IUpload
    {
        private BlobContainerClient blobContainerClient;

        public UploadAzureService()
        {
            //blobContainerClient = new BlobContainerClient("DefaultEndpointsProtocol=https;AccountName=utopios;AccountKey=eYFsdjjsLbUfqt4TE9m3EKBDbHmmo/IzRHqHAMGcY6K+qoGGoYJPWG5mnVRG54VhFwF5XEMl55h6+AStP+Olzg==;EndpointSuffix=core.windows.net", "images-ihab");
            blobContainerClient = new BlobContainerClient(new Uri("utopios.blob.core.windows.net/images-ihab"), new DefaultAzureCredential());
        }
        public string Upload(IFormFile file)
        {
            Stream m = file.OpenReadStream();
            BlobClient blob = blobContainerClient.GetBlobClient(file.FileName);
            blob.Upload(m);
            return blob.Uri.ToString();
        }
    }
}
