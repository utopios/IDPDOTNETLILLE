using CorrectionPetiteAnnonce.Models;
using Microsoft.EntityFrameworkCore;

namespace CorrectionPetiteAnnonce.Services
{
    public class DataContextService : DbContext
    {       
        public DbSet<Categorie> Categories { get; set; }

        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public DbSet<Annonce> Annonces { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Desktop\IDPDOTNETLILLE\FormationDotNet\dbEntity.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
