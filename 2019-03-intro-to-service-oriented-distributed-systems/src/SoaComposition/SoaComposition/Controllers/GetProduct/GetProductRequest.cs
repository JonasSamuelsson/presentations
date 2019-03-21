using Handyman.Mediator;
using SoaComposition.Controllers.GetProduct.DataContracts;

namespace SoaComposition.Controllers.GetProduct
{
   public class GetProductRequest : IRequest<Product>
   {
      public int Id { get; set; }
   }
}