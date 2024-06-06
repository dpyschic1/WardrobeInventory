namespace WardrobeInventory.Infrastructure.DTO
{
    public class WardrobeItemDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[]? Image { get; set; }
        public string? ImageUrl { get; set; }
    }
}