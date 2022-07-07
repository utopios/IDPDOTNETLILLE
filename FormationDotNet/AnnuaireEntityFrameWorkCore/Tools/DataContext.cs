using AnnuaireEntityFrameWorkCore.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireEntityFrameWorkCore.Tools
{
    public class DataContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\cousDotNet;Integrated Security=True");
        }
    }
}
