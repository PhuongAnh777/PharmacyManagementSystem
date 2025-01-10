
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyManagementSystem.Models

{
    public class PurchaseDetail
    {
        public Guid PurchaseDetailID { get; set; } // NCHAR(10)

        public Guid PurchaseID { get; set; } // NCHAR(10)

        public Guid ProductID { get; set; } // NCHAR(10)

        public int Quantity { get; set; } // INT

        public decimal Price { get; set; } // DECIMAL(10, 2)

        public virtual Purchase Purchase { get; set; }

        public virtual Product Product { get; set; }
    }

}