using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementSystem.Models
{
    public class OrderDetail
    {
        public Guid OrderDetailID { get; set; } // NCHAR(10)

        public Guid OrderID { get; set; } // NCHAR(10)

        public Guid ProductID { get; set; } // NCHAR(10)

        public int Quantity { get; set; } // INT

        public decimal Price { get; set; } // DECIMAL(10, 2)

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }

}