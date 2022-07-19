using System.ComponentModel.DataAnnotations.Schema;

namespace CorrectionPetiteAnnonce.Models
{
    [Table("image")]
    public class Image
    {
        private int id;
        private string uri;

        private int annonceId;

        [Column("id")]
        public int Id { get => id; set => id = value; }
        
        [Column("uri")]
        public string Uri { get => uri; set => uri = value; }
        
        [Column("annonce_id")]
        public int AnnonceId { get => annonceId; set => annonceId = value; }

        [ForeignKey("AnnonceId")]
        public Annonce Annonce { get; set; }
    }
}
