using System.Threading;
using System.Threading.Tasks;
using Handyman.Mediator;
using SoaComposition.Clients.Pricing;
using SoaComposition.Controllers.GetProduct.Events;

namespace SoaComposition.Controllers.GetProduct.Services.Pricing
{
   public class ProductLoadedHandler : IEventHandler<ProductLoadedEvent>
   {
      private readonly PricingClient _client;

      public ProductLoadedHandler(PricingClient client)
      {
         _client = client;
      }

      public async Task Handle(ProductLoadedEvent @event, CancellationToken cancellationToken)
      {
         @event.Product.Price = await _client.GetPrice(@event.Product.Id);
      }
   }
}
