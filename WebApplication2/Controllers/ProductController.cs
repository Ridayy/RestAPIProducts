using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private List<Product> products = new List<Product> { 
            new Product{id = 1, productName = "Ampoule Serum", productDescription = "..." , productPrice= 400},
            new Product{id = 2, productName = "Ear Phones", productDescription = "..." , productPrice= 400},
             new Product{id = 3, productName = "Hair Gel", productDescription = "..." , productPrice= 400}
        };

        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            Product product = products.FirstOrDefault(p => p.id == id);
            if(product == null)
            {
                return NotFound( new { Message = "Product Not Found" } );
            }
            return Ok(product);
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult<IEnumerable<Product>> Post(Product newProduct)
        {
            products.Add(newProduct);
            return products;
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Product>> Put(int id, Product updatedProduct)
        {
            Product product = products.FirstOrDefault(p => p.id == id);
            if (product == null)
            {
                return NotFound(new { Message = "Product Not Found" });
            }

            product.productName = updatedProduct.productName;
            product.productDescription = updatedProduct.productDescription;
            product.productPrice = updatedProduct.productPrice;
            product.isDeleted = updatedProduct.isDeleted;

            return products;
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Product>> Delete(int id)
        {

            Product product = products.FirstOrDefault(p => p.id == id);
            if (product == null)
            {
                return NotFound(new { Message = "Product Not Found" });
            }

            products.Remove(product);

            return products;
        }


    }
}
