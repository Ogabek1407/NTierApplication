namespace NTierApplication.Domain.Models
{
    public class Item
    {
        public long ItemId { get; set; }
        public int ItemType { get; set; }
        public string ItemName { get; set; }
        public DateTime ItemDate { get; set; }
    }
}
