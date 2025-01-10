using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementSystem.Models
{
    public class Supplier
    {
        public Guid SupplierID { get; set; } // NCHAR(10)

        public string Name { get; set; } // NVARCHAR(100)

        public string? PhoneNumber { get; set; } // NVARCHAR(15)

        public string? Email { get; set; } // NVARCHAR(100)

        public string? Address { get; set; } // NVARCHAR(MAX)
        public bool IsDiscontinued { get; set; } // Mặc định chưa ngừng

        public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }

}