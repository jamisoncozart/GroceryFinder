namespace GroceryFinder.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int OpenHour { get; set; }
        public int CloseHour { get; set; }
        public bool Delivery { get; set; }
        public string Description { get; set; }
    }
}