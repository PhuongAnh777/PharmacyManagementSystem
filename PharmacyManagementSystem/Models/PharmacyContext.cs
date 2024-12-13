using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace PharmacyManagementSystem.Models
{
    public class PharmacyContext : DbContext
    {
        public PharmacyContext(DbContextOptions<PharmacyContext> options)
        : base(options)
        {
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<MedicineCategory> MedicineCategories { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-APUENFVC\\SQLEXPRESS;Database=PharmacyManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerID);
                entity.Property(e => e.CustomerID).HasMaxLength(10);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.PhoneNumber).HasMaxLength(15);
                entity.Property(e => e.Email).HasMaxLength(100);
            });

            modelBuilder.Entity<MedicineCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryID);
                entity.Property(e => e.CategoryID).HasMaxLength(10);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.HasKey(e => e.MedicineID);
                entity.Property(e => e.MedicineID).HasMaxLength(10);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
                entity.HasOne(e => e.MedicineCategory)
                      .WithMany()
                      .HasForeignKey(e => e.CategoryID);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeID);
                entity.Property(e => e.EmployeeID).HasMaxLength(10);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Gender).IsRequired();
                entity.Property(e => e.PhoneNumber).HasMaxLength(15);
                entity.Property(e => e.Email).HasMaxLength(100);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderID);
                entity.Property(e => e.OrderID).HasMaxLength(10);
                entity.Property(e => e.OrderDate).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");
                entity.HasOne(e => e.Customer)
                      .WithMany()
                      .HasForeignKey(e => e.CustomerID);
                entity.HasOne(e => e.Employee)
                      .WithMany()
                      .HasForeignKey(e => e.EmployeeID);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailID);
                entity.Property(e => e.OrderDetailID).HasMaxLength(10);
                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
                //entity.HasOne(e => e.Order)
                //      .WithMany(o => o.OrderDetails)
                //      .HasForeignKey(e => e.OrderID);
                entity.HasOne(e => e.Medicine)
                      .WithMany()
                      .HasForeignKey(e => e.MedicineID);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.SupplierID);
                entity.Property(e => e.SupplierID).HasMaxLength(10);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.PhoneNumber).HasMaxLength(15);
                entity.Property(e => e.Email).HasMaxLength(100);
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasKey(e => e.PurchaseID);
                entity.Property(e => e.PurchaseID).HasMaxLength(10);
                entity.Property(e => e.PurchaseDate).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");
                entity.HasOne(e => e.Supplier)
                      .WithMany()
                      .HasForeignKey(e => e.SupplierID);
                entity.HasOne(e => e.Employee)
                      .WithMany()
                      .HasForeignKey(e => e.EmployeeID);
            });

            modelBuilder.Entity<PurchaseDetail>(entity =>
            {
                entity.HasKey(e => e.PurchaseDetailID);
                entity.Property(e => e.PurchaseDetailID).HasMaxLength(10);
                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
                //entity.HasOne(e => e.Purchase)
                //      .WithMany(p => p.PurchaseDetails)
                //      .HasForeignKey(e => e.PurchaseID);
                entity.HasOne(e => e.Medicine)
                      .WithMany()
                      .HasForeignKey(e => e.MedicineID);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.InventoryID);
                entity.Property(e => e.InventoryID).HasMaxLength(10);
                entity.Property(e => e.StockQuantity).IsRequired();
                entity.Property(e => e.LastUpdated).HasDefaultValueSql("GETDATE()");
                entity.HasOne(e => e.Medicine)
                      .WithMany()
                      .HasForeignKey(e => e.MedicineID);
            });
        }
    }
}
