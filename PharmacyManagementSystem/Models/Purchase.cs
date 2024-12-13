namespace PharmacyManagementSystem.Models
{
    public class Purchase
    {
        public string PurchaseID { get; set; }
        public string SupplierID { get; set; }
        public string EmployeeID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalAmount { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Employee Employee { get; set; }
        //public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}