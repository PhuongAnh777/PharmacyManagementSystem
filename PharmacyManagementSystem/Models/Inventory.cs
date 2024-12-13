namespace PharmacyManagementSystem.Models
{
    public class Inventory
    {
        public string InventoryID { get; set; }
        public string MedicineID { get; set; }
        public int StockQuantity { get; set; }
        public DateTime LastUpdated { get; set; }
        public Medicine Medicine { get; set; }
    }
}