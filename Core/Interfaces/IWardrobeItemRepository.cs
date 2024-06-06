using WardrobeInventory.Entities;
using WardrobeInventory.Infrastructure.DTO;

namespace WardrobeInventory.Core.Interfaces
{
    public interface IWardrobeItemRepository
    {
        WardrobeItem GetItemByIdAsync(int id);
        void AddWardrobeItem(WardrobeItemDto wardrobeItemDto);
    }
}