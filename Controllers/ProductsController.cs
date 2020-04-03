using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product>_products = new List<Product>()
        {
            new Product(){ProductId = 0, ProductName = "Laptop", ProductPrice = "8000"},
            new Product(){ProductId = 0, ProductName = "SmartPhone", ProductPrice = "5000"},
        };
        
        // GET: api/products
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public void PutProduct([FromRoute] int id, [FromBody] Product product)
        {
            _products[id] = product;
        }

        // POST: api/Products
        [HttpPost]
        public void PostProduct([FromBody] Product product)
        {
            _products.Add(product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public void DeleteProduct([FromRoute] int id)
        {
            _products.RemoveAt(id);
        }
    }
}
