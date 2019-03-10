using Boxed.AspNetCore;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace SoaComposition.Clients.ProductCatalog
{
   public class ProductCatalogClient
   {
      private static readonly Dictionary<int, string> Data = new Dictionary<int, string>
      {
         {1, "Apple AirPods"},
         {2, "Nintendo Switch"},
         {3, "Bose QuietComfort 35 II"}
      };

      public Task<string> GetProduct(int id)
      {
         if (!Data.TryGetValue(id, out var name))
            throw new HttpException(HttpStatusCode.NotFound);

         return Task.FromResult(name);
      }
   }
}
