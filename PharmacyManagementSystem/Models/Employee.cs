namespace PharmacyManagementSystem.Models
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        //public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}