using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementSystem.Models
{
    public class Category
    {
        public Guid CategoryID { get; set; } // NCHAR(10)

        public string Name { get; set; } // NVARCHAR(100)

        public string Description { get; set; } // NVARCHAR(MAX)
        public Guid? ParentCategoryID { get; set; }
        public Category ParentCategory { get; set; }

        public virtual ICollection<Product> Medicines { get; set; } = new List<Product>();
    }

}