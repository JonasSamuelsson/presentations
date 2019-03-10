using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoaComposition.Clients.Inventory
{
   public class InventoryClient
   {
      private static readonly Dictionary<int, string> Data = new Dictionary<int, string>
      {
         {1, "50+"},
         {2, "low"},
         {3, "out of stock"}
      };

      public Task<string> GetInventory(int productId)
      {
         var availability = Data[productId];
         return Task.FromResult(availability);
      }
   }
}
