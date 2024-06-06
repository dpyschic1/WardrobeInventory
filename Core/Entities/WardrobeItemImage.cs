namespace WardrobeInventory.Entities
{
    public class WardrobeItemImage
    {
        public int Id { get; set; }
        public int WardrobeId { get; set; }
        public byte[]? WardrobeImage { get; set; }
        public string? PhotoUrl {get; set; }
        public WardrobeItem WardrobeItem{ get; set; } = null!;
    }
}