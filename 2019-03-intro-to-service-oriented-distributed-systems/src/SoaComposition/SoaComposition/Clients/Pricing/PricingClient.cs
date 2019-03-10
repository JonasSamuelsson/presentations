using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoaComposition.Clients.Pricing
{
   public class PricingClient
   {
      private static readonly Dictionary<int, decimal> Data = new Dictionary<int, decimal>
      {
         {1, 1759},
         {2, 3343},
         {3, 2990}
      };

      public Task<decimal> GetPrice(int productId)
      {
         var price = Data[productId];
         return Task.FromResult(price);
      }
   }
}
