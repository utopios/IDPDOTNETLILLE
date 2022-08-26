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
        
        public DbSet<CashRegistryUser> Users { get; set; }
        public DbSet<CashPayment> CashPayments { get; set; }
        public DbSet<CardPayment> CardPayments { get; set; }
        public DataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:utopios.database.windows.net,1433;Initial Catalog=demo-ihab;Authentication=Active Directory Default;");
        }
    }
}
