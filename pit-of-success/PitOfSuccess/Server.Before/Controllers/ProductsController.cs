using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Server.Before.Controllers
{
   [ApiController, Route("[controller]")]
   public class ProductsController : ControllerBase
   {
      [HttpGet("{id:int}")]
      public Product GetProduct(int id)
      {
         return new Product
         {
            Id = 1,
            Name = "Samsung Galaxy S11"
         };
      }

      [HttpPut("{id:int}")]
      public Product UpdateProduct(int id, Product product)
      {
         product.Id = id;
         return product;
      }

      [HttpGet("{id:int}/reviews")]
      public IEnumerable<object> GetProductReviews(int id)
      {
         return new object[]
         {
            new { User = "Jane Doe", Text = "Great stuff."},
            new { User = "John Doe", Text = "Pure crap."}
         };
      }

      public class Product
      {
         public int Id { get; set; }
         public string Name { get; set; }
      }
   }
}
