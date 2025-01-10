using System;
using System.Collections.Generic;
using System.Data;
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
        public PharmacyContext()
        {
        }

        public PharmacyContext(DbContextOptions<PharmacyContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-APUENFVC\\SQLEXPRESS;Database=Pharmacy;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
            }
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerID);
                entity.Property(e => e.CustomerID).HasDefaultValueSql("NEWID()");
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.PhoneNumber).HasMaxLength(15);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.Address).HasColumnType("NVARCHAR(MAX)");
                entity.Property(e => e.Image).HasColumnType("VARBINARY(MAX)"); // Lưu ảnh dạng nhị phân
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryID);
                entity.Property(e => e.CategoryID).HasDefaultValueSql("NEWID()");
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).HasColumnType("NVARCHAR(MAX)");

                entity.Property(c => c.ParentCategoryID)
                    .IsRequired(false);

                entity.HasOne(c => c.ParentCategory)
                    .WithMany()  // You can configure it to have many subcategories if needed
                    .HasForeignKey(c => c.ParentCategoryID)
                    .OnDelete(DeleteBehavior.Restrict) // Change this to suit your needs
                    .HasConstraintName("FK_Categories_Categories_ParentCategoryID");

            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductID);
                entity.Property(ua => ua.ProductID).HasDefaultValueSql("NEWID()");
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.ActiveIngredient).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Dosage).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Packaging).HasMaxLength(100);
                entity.Property(e => e.Unit).HasMaxLength(50);
                entity.Property(e => e.Price).HasColumnType("DECIMAL(10,2)").IsRequired();
                entity.Property(e => e.Manufacturer).HasMaxLength(100);
                entity.Property(e => e.StockQuantity).IsRequired();
                entity.Property(e => e.ExpiryDate).HasColumnType("DATE").IsRequired();
                entity.Property(e => e.Image).HasColumnType("VARBINARY(MAX)"); // Lưu ảnh dạng nhị phân

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Medicines)
                    .HasForeignKey(d => d.CategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicines_MedicineCategories");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeID);
                entity.Property(ua => ua.EmployeeID).HasDefaultValueSql("NEWID()");
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Gender).IsRequired();
                entity.Property(e => e.Position).HasMaxLength(50);
                entity.Property(e => e.PhoneNumber).HasMaxLength(15);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.Image).HasColumnType("VARBINARY(MAX)"); // Lưu ảnh dạng nhị phân

                // Relationship with UserAccount (assuming UserAccount entity has been defined)
                entity.HasOne(e => e.UserAccount)
                    .WithOne(ua => ua.Employee)  // One-to-one relationship
                    .HasForeignKey<Employee>(e => e.AccountID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserAccount_AccountID");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleID);
                entity.Property(ua => ua.RoleID).HasDefaultValueSql("NEWID()");
                entity.Property(e => e.RoleName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Description).HasColumnType("NVARCHAR(MAX)");
            });

            modelBuilder.Entity<EmployeeRole>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeID, e.RoleID });

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeRoles)
                    .HasForeignKey(d => d.EmployeeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeRoles_Employees");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.EmployeeRoles)
                    .HasForeignKey(d => d.RoleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeRoles_Roles");
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.HasKey(e => e.AccountID);
                entity.Property(ua => ua.AccountID).HasDefaultValueSql("NEWID()");
                entity.Property(e => e.Username).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderID);
                entity.Property(ua => ua.OrderID).HasDefaultValueSql("NEWID()");
                entity.Property(e => e.OrderDate).HasDefaultValueSql("(getdate())").HasColumnType("datetime");
                entity.Property(e => e.TotalAmount).HasColumnType("DECIMAL(10,2)").IsRequired();
                entity.Property(e => e.PaymentMethod).IsRequired();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Customers");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Employees");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailID);
                entity.Property(ua => ua.OrderDetailID).HasDefaultValueSql("NEWID()");
                entity.Property(e => e.Quantity).IsRequired();
                entity.Property(e => e.Price).HasColumnType("DECIMAL(10,2)").IsRequired();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_Medicines");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.SupplierID);
                entity.Property(ua => ua.SupplierID).HasDefaultValueSql("NEWID()");
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.PhoneNumber).HasMaxLength(15);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.Address).HasColumnType("NVARCHAR(MAX)");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasKey(e => e.PurchaseID);
                entity.Property(ua => ua.PurchaseID).HasDefaultValueSql("NEWID()");
                entity.Property(e => e.PurchaseDate).HasDefaultValueSql("(getdate())").HasColumnType("datetime");
                entity.Property(e => e.TotalAmount).HasColumnType("DECIMAL(10,2)").IsRequired();

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.SupplierID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Purchases_Suppliers");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.EmployeeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Purchases_Employees");
            });

            modelBuilder.Entity<PurchaseDetail>(entity =>
            {
                entity.HasKey(e => e.PurchaseDetailID);
                entity.Property(ua => ua.PurchaseDetailID).HasDefaultValueSql("NEWID()");
                entity.Property(e => e.Quantity).IsRequired();
                entity.Property(e => e.Price).HasColumnType("DECIMAL(10,2)").IsRequired();

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.PurchaseID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetails_Purchases");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.ProductID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetails_Medicines");
            });


        }
    }

}
