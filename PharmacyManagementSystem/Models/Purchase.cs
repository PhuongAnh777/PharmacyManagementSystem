using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementSystem.Models
{
    public class Purchase
    {
        public Guid PurchaseID { get; set; } // NCHAR(10)

        public Guid SupplierID { get; set; } // NCHAR(10)

        public Guid EmployeeID { get; set; } // NCHAR(10)

        public DateTime PurchaseDate { get; set; } // DATETIME

        public decimal TotalAmount { get; set; } // DECIMAL(10, 2)

        public virtual Supplier Supplier { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();
    }

}