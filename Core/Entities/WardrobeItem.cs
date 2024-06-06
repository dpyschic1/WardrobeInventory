namespace WardrobeInventory.Entities
{
    public class WardrobeItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public string? AddedBy { get; set; }
        public string? DeletedBy { get; set; }
        public WardrobeItemImage? WardrobeItemImage{ get; set; }
    }
}