using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementSystem.Models
{
    public class Order
    {
        public Guid OrderID { get; set; } // NCHAR(10)

        public Guid? CustomerID { get; set; } // NCHAR(10)

        public Guid? EmployeeID { get; set; } // NCHAR(10)

        public DateTime OrderDate { get; set; } // DATETIME

        public decimal TotalAmount { get; set; } // DECIMAL(10, 2)

        public string PaymentMethod { get; set; } // Default is cash
        public string? Note { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }

}