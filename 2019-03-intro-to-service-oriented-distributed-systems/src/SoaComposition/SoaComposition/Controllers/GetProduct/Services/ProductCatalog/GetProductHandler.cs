using System.Threading;
using System.Threading.Tasks;
using Handyman.Mediator;
using SoaComposition.Clients.ProductCatalog;
using SoaComposition.Controllers.GetProduct.DataContracts;
using SoaComposition.Controllers.GetProduct.Events;

namespace SoaComposition.Controllers.GetProduct.Services.ProductCatalog
{
   public class GetProductHandler : IRequestHandler<GetProductRequest, Product>
   {
      private readonly ProductCatalogClient _client;
      private readonly IMediator _mediator;

      public GetProductHandler(ProductCatalogClient client, IMediator mediator)
      {
         _client = client;
         _mediator = mediator;
      }

      public async Task<Product> Handle(GetProductRequest request, CancellationToken cancellationToken)
      {
         var name = await _client.GetProduct(request.Id);

         var product = new Product
         {
            Id = request.Id,
            Name = name
         };

         await _mediator.Publish(new ProductLoadedEvent { Product = product });

         return product;
      }
   }
}
