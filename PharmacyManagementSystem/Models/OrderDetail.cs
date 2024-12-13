namespace PharmacyManagementSystem.Models
{
    public class OrderDetail
    {
        public string OrderDetailID { get; set; }
        public string OrderID { get; set; }
        public string MedicineID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; }
        public Medicine Medicine { get; set; }
    }
}