namespace PharmacyManagementSystem.Models
{
    public class PurchaseDetail
    {
        public string PurchaseDetailID { get; set; }
        public string PurchaseID { get; set; }
        public string MedicineID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Purchase Purchase { get; set; }
        public virtual Medicine Medicine { get; set; }
    }
}