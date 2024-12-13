namespace PharmacyManagementSystem.Models
{
    public class Medicine
    {
        public string MedicineID { get; set; }
        public string Name { get; set; }
        public string CategoryID { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string ActiveIngredient { get; set; }
        public string Dosage { get; set; }
        public string Packaging { get; set; }
        public string Unit { get; set; }
        //public virtual ICollection<Order> OrderItems { get; set; } = new List<Order>();
        public virtual MedicineCategory MedicineCategory { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}