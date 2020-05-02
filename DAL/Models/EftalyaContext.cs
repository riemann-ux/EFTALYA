using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class EftalyaContext : DbContext
    {
        public EftalyaContext()
        {
        }

        public EftalyaContext(DbContextOptions<EftalyaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersProducts> OrdersProducts { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = localhost; initial catalog= Eftalya; integrated security = true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.Property(e => e.AddressCity).HasMaxLength(30);

                entity.Property(e => e.AddressCountry).HasMaxLength(20);

                entity.Property(e => e.AddressState).HasMaxLength(30);

                entity.Property(e => e.AdressStreet).HasMaxLength(30);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Addresses_Customers");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerEmail).HasMaxLength(100);

                entity.Property(e => e.CustomerLastname).HasMaxLength(30);

                entity.Property(e => e.CustomerName).HasMaxLength(30);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.EmployeeEmail).HasMaxLength(50);

                entity.Property(e => e.EmployeeLastname).HasMaxLength(30);

                entity.Property(e => e.EmployeeName).HasMaxLength(30);

                entity.Property(e => e.EmployeePassword).HasMaxLength(30);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Orders_Customers");
            });

            modelBuilder.Entity<OrdersProducts>(entity =>
            {
                entity.HasKey(e => e.OrderProductId);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrdersProducts)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrdersProducts_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrdersProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrdersProducts_Products");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ProductDescription).HasMaxLength(250);

                entity.Property(e => e.ProductName).HasMaxLength(30);

                entity.Property(e => e.ProductPrice).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
