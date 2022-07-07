using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursEntityFrameWorkCore
{
    public class DataContext : DbContext
    {
        public DbSet<Personne> Personnes { get; set; }

        public DbSet<Adresse> Adresses { get; set; }
        public DataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\cousDotNet;Integrated Security=True");
        }
    }
}
