namespace PharmacyManagementSystem.Models
{
    public class Order
    {
        public string OrderID { get; set; }
        public string CustomerID { get; set; }
        public string EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        //public virtual  ICollection<OrderDetail> OrderDetails { get; set; }
    }
}