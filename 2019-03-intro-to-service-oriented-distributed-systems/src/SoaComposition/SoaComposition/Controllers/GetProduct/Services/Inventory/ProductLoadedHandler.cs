﻿using Handyman.Mediator;
using SoaComposition.Clients.Inventory;
using SoaComposition.Controllers.GetProduct.Events;
using System.Threading;
using System.Threading.Tasks;

namespace SoaComposition.Controllers.GetProduct.Services.Inventory
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
         try
         {
            @event.Product.Inventory = await _client.GetInventory(@event.Product.Id);
         }
         catch
         {
            @event.Product.Inventory = "?";
         }
      }
   }
}