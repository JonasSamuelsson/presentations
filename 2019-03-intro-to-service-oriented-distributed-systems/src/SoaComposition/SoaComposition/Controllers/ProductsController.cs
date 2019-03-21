using Handyman.Mediator;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SoaComposition.Controllers.GetProduct.DataContracts;

namespace SoaComposition.Controllers
{
   [ApiController, Route("api/[controller]")]
   public class ProductsController : ControllerBase
   {
      private readonly IMediator _mediator;

      public ProductsController(IMediator mediator)
      {
         _mediator = mediator;
      }

      [HttpGet("{id}")]
      public async Task<Product> Get(int id)
      {
         return await _mediator.Send(new GetProduct.GetProductRequest { Id = id });
      }
   }
}
