using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementSystem.Models
{
    public class EmployeeRole
    {
        public Guid EmployeeID { get; set; } // NCHAR(10)

        public Guid RoleID { get; set; } // NCHAR(10)

        public virtual Employee Employee { get; set; }

        public virtual Role Role { get; set; }
    }

}