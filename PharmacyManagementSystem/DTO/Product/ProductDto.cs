using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.DTO.Product
{
    public class ProductDto
    {
        public Guid ID { get; set; }
        public string ImageName {  get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal OriginalPrice { get; set; }
        public int StockQuantity { get; set; }

    }
}
