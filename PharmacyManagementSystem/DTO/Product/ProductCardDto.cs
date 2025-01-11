using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.DTO.Product
{
    public class ProductCardDto
    {
        public Guid ProductID { get; set; }
        public string Name { get; set; } // NVARCHAR(100)
        public string? Image { get; set; }
        public decimal SellingPrice { get; set; }
        public int StockQuantity { get; set; }
    }
}
