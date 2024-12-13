namespace PharmacyManagementSystem.Models
{
    public class MedicineCategory
    {
        public string CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public virtual ICollection<MedicineCategory> MedicineCategories { get; set; } = new List<MedicineCategory>();
    }
}