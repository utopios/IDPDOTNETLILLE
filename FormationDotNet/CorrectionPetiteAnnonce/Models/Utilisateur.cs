using System.ComponentModel.DataAnnotations.Schema;

namespace CorrectionPetiteAnnonce.Models
{

    [Table("utilisateur")]
    public class Utilisateur
    {
        private int id;
        private string email;
        private string password;
        private string role;

        [Column("email")]
        public string Email { get => email; set => email = value; }
        [Column("password")]
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
        [Column("role")]
        public string Role { get => role; set => role = value; }
    }
}
