using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.DTO.Product
{
    public class ProductCreateDto
    {
        public string? MedicineID { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? CountryOfOrigin { get; set; }
        public string Name { get; set; }
        public string? ActiveIngredient { get; set; }
        public string? Dosage { get; set; }
        public string? Packaging { get; set; }
        public string? Unit { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public string? Description { get; set; }
        public string? Manufacturer { get; set; }
        public int StockQuantity { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public Guid CategoryID { get; set; }
        public Guid? SupplierID { get; set; }
        public string? Image { get; set; }
    }
}
