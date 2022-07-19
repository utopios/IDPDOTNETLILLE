using System.ComponentModel.DataAnnotations.Schema;

namespace CorrectionPetiteAnnonce.Models
{
    [Table("categorie")]
    public class Categorie
    {
        private int id;
        private string titre;

        [Column("id")]
        public int Id { get => id; set => id = value; }

        [Column("titre")]
        public string Titre { get => titre; set => titre = value; }
    }
}
