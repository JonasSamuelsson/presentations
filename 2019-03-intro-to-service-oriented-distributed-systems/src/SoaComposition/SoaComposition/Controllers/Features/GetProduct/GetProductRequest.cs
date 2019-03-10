using Handyman.Mediator;
using SoaComposition.Controllers.Features.GetProduct.DataContracts.Output;

namespace SoaComposition.Controllers.GetProduct
{
   public class GetProductRequest : IRequest<Product>
   {
      public int Id { get; set; }
   }
}