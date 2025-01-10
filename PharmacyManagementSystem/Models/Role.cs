using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementSystem.Models
{
    public class Role
    {
        public Guid RoleID { get; set; } // NCHAR(10)

        public string RoleName { get; set; } // NVARCHAR(50)

        public string Description { get; set; } // NVARCHAR(MAX)

        public virtual ICollection<EmployeeRole> EmployeeRoles { get; set; } = new List<EmployeeRole>();
    }

}