using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testerino.Data;

namespace testerino.Models
{
    public class InventoryRepository : IInventoryRepository
    {
        private ApplicationDbContext _context;

        public InventoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Inventory> getAllInventories()
        {
            return _context.Inventory.ToList();
        }

        public void AddInventory(Inventory inventory)
        {
            _context.Add(inventory);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

    }
}
