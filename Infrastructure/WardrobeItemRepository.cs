using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WardrobeInventory.Core.Interfaces;
using WardrobeInventory.Entities;
using WardrobeInventory.Infrastructure.DTO;

namespace WardrobeInventory.Infrastructure
{
    public class WardrobeItemRepository : IWardrobeItemRepository
    {
        public void AddWardrobeItem(WardrobeItemDto wardrobeItemDto)
        {
            
        }

        public WardrobeItem GetItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}