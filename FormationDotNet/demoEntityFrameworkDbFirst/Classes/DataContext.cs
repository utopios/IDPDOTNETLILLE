using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace demoEntityFrameworkDbFirst.Classes
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<CardPayment> CardPayments { get; set; } = null!;
        public virtual DbSet<CashPayment> CashPayments { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Operation> Operations { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductOrder> ProductOrders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrateur\\Desktop\\IDPDOTNETLILLE\\FormationDotNet\\dbEntity.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.HasIndex(e => e.CustomerId, "IX_account_customer_id");

                entity.Property(e => e.AccountNumber).HasColumnName("account_number");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total_amount");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<CardPayment>(entity =>
            {
                entity.ToTable("card_payment");

                entity.HasIndex(e => e.PaymentId, "IX_card_payment_PaymentId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CardPaymentIdNavigation)
                    .HasForeignKey<CardPayment>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.CardPaymentPayments)
                    .HasForeignKey(d => d.PaymentId);
            });

            modelBuilder.Entity<CashPayment>(entity =>
            {
                entity.ToTable("cash_payment");

                entity.HasIndex(e => e.PaymentId, "IX_cash_payment_PaymentId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Change).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CashPaymentIdNavigation)
                    .HasForeignKey<CashPayment>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.CashPaymentPayments)
                    .HasForeignKey(d => d.PaymentId);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Operation>(entity =>
            {
                entity.ToTable("operation");

                entity.HasIndex(e => e.AccountId, "IX_operation_account_id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.OperationDateTime).HasColumnName("operation_date_time");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Operations)
                    .HasForeignKey(d => d.AccountId);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.PaymentId, "IX_Orders_PaymentId");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PaymentId);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ProductOrder>(entity =>
            {
                entity.ToTable("ProductOrder");

                entity.HasIndex(e => e.OrderId, "IX_ProductOrder_OrderId");

                entity.HasIndex(e => e.ProductId, "IX_ProductOrder_ProductId");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ProductOrders)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductOrders)
                    .HasForeignKey(d => d.ProductId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
