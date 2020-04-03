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

        public IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}
