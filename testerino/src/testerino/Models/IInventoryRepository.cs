using System.Collections.Generic;
using System.Threading.Tasks;

namespace testerino.Models
{
    public interface IInventoryRepository
    {
        void AddInventory(Inventory inventory);
        IEnumerable<Inventory> getAllInventories();
        Task<bool> SaveChangesAsync();
    }
}