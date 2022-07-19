using System.ComponentModel.DataAnnotations.Schema;

namespace CorrectionPetiteAnnonce.Models
{
    [Table("annonce")]
    public class Annonce
    {
        private int id;
        private string titre;
        private string description;
        private decimal prix;
        private int categorieId;

        [Column("id")]
        public int Id { get => id; set => id = value; }

        [Column("titre")]
        public string Titre { get => titre; set => titre = value; }
        
        [Column("description",TypeName = "Text")]
        public string Description { get => description; set => description = value; }

        [Column("prix")]
        public decimal Prix { get => prix; set => prix = value; }

        [Column("categorie_id")]
        public int CategorieId { get => categorieId; set => categorieId = value; }

        [ForeignKey("CategorieId")]
        public Categorie Categorie { get; set; }

        public List<Image> Images { get; set; }

        public Annonce()
        {
            Images = new List<Image>();
        }
    }
}
