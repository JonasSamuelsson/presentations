using Handyman.Mediator;
using SoaComposition.Clients.Inventory;
using SoaComposition.Controllers.Features.GetProduct.Events;
using System.Threading;
using System.Threading.Tasks;

namespace SoaComposition.Controllers.Features.GetProduct.Services.Inventory
{
   public class ProductLoadedHandler : IEventHandler<ProductLoadedEvent>
   {
      private readonly InventoryClient _client;

      public ProductLoadedHandler(InventoryClient client)
      {
         _client = client;
      }

      public async Task Handle(ProductLoadedEvent @event, CancellationToken cancellationToken)
      {
         @event.Product.Inventory = await _client.GetInventory(@event.Product.Id);
      }
   }
}
