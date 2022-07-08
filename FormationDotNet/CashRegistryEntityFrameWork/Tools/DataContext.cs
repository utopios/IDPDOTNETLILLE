using CashRegistryEntityFrameWork.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegistryEntityFrameWork.Tools
{
    public class DataContext : DbContext
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        
        public DbSet<CashPayment> CashPayments { get; set; }
        public DbSet<CardPayment> CardPayments { get; set; }
        public DataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Desktop\IDPDOTNETLILLE\FormationDotNet\dbEntity.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
