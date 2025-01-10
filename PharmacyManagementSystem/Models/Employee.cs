using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementSystem.Models
{
    public class Employee
    {
        public Guid EmployeeID { get; set; } // NCHAR(10)

        public string Name { get; set; } // NVARCHAR(100)

        public bool? Gender { get; set; } // BIT

        public string? PhoneNumber { get; set; } // NVARCHAR(15)

        public string? Email { get; set; } // NVARCHAR(100)
        public DateTime? DateOfBirth {  get; set; } 

        public Guid? AccountID { get; set; }
        public string? Image { get; set; }
        public bool IsDiscontinued { get; set; }  // Mặc định chưa ngừng
        public virtual UserAccount UserAccount { get; set; }
        public virtual ICollection<EmployeeRole> EmployeeRoles { get; set; } = new List<EmployeeRole>();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }

}