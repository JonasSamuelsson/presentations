using Handyman.Mediator;
using SoaComposition.Controllers.Features.GetProduct.DataContracts.Output;

namespace SoaComposition.Controllers.Features.GetProduct.Events
{
   public class ProductLoadedEvent : IEvent
   {
      public Product Product { get; set; }
   }
}
