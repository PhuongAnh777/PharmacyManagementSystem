using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementSystem.Models
{
    public class UserAccount
    {
        public Guid AccountID { get; set; }

        public string Username { get; set; } // NVARCHAR(50)

        public string Password { get; set; } // NVARCHAR(100
        public virtual Employee Employee { get; set; }
    }

}