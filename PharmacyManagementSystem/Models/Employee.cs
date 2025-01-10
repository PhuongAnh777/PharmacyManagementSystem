using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementSystem.Models
{
    public class Employee
    {
        public Guid EmployeeID { get; set; } // NCHAR(10)

        public string Name { get; set; } // NVARCHAR(100)

        public bool? Gender { get; set; } // BIT

        public string? Position { get; set; } // NVARCHAR(50)

        public string? PhoneNumber { get; set; } // NVARCHAR(15)

        public string? Email { get; set; } // NVARCHAR(100)

        public Guid? AccountID { get; set; }
        public byte[] Image { get; set; }

        public virtual UserAccount UserAccount { get; set; }
        public virtual ICollection<EmployeeRole> EmployeeRoles { get; set; } = new List<EmployeeRole>();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }

}