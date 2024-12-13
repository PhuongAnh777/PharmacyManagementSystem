namespace PharmacyManagementSystem.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        //public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}