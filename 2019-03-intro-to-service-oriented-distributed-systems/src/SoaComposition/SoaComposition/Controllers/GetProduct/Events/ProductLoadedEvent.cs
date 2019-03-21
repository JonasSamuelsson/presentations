using Handyman.Mediator;
using SoaComposition.Controllers.GetProduct.DataContracts;

namespace SoaComposition.Controllers.GetProduct.Events
{
   public class ProductLoadedEvent : IEvent
   {
      public Product Product { get; set; }
   }
}
