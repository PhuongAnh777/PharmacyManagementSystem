using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyManagementSystem.Models
{
    public class Customer
    {
        public Guid CustomerID { get; set; } 

        public string Name { get; set; } // NVARCHAR(100)

        public string? PhoneNumber { get; set; } // NVARCHAR(15)

        public string? Email { get; set; } // NVARCHAR(100)

        public string? Address { get; set; } // NVARCHAR(MAX)
        public string? Image { get; set; }

        public bool IsDiscontinued { get; set; } // Mặc định chưa ngừng

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}