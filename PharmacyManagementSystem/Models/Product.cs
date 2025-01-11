using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementSystem.Models
{
    public class Product
    {
        public Guid ProductID { get; set; } // NCHAR(10)
        public string? MedicineID { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? CountryOfOrigin {  get; set; }

        public string Name { get; set; } // NVARCHAR(100)

        public string ActiveIngredient { get; set; } // NVARCHAR(100)

        public string? Dosage { get; set; } // NVARCHAR(50)

        public string Packaging { get; set; } // NVARCHAR(100)

        public string? Unit { get; set; } // NVARCHAR(50)

        public decimal OriginalPrice { get; set; } // DECIMAL(10, 2)
        public decimal? SellingPrice { get; set; }
        public string? Description { get; set; } // NVARCHAR(MAX)
        public string Manufacturer { get; set; } // NVARCHAR(100)

        public int StockQuantity { get; set; } // INT

        public DateTime? ExpiryDate { get; set; } // DATE

        public Guid CategoryID { get; set; } // NCHAR(10)
        public Guid? SupplierID { get; set; } // NCHAR(10)
        public string? Image { get; set; }
        public bool IsDiscontinued { get; set; }    // Mặc định chưa ngừng

        public virtual Category Category { get; set; } // Foreign Key
        public virtual Supplier Supplier { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();
    }

}