using ProductsAppWithWebAPI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsAppWithWebAPI2.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {Id=1,Name="Domates Çorbası",Category="Bakkal",Price=1 },
            new Product {Id=2,Name="Yo-yo",Category="Oyuncak",Price=3.75M },
            new Product {Id=3,Name="Çekiç",Category="Donanım",Price=16.99M }
        };

        public IEnumerable<Product> GetAllProducts()//IEnumerable implement Array, List, ArrayList, Hashtable. Used Foreach or while
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);            
            if (product == null)
            {
                return NotFound();
            }
            return Ok(products);
        }
    }
}
