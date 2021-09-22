using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VeganApi.Interfaces;
using VeganApi.Models;

namespace VeganApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IRepository _repo;
        public ProductController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("[Action]")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return Ok(new { products = await _repo.SelectAll<Product>() });
        }

        [HttpGet("[Action]/{id}")]
        public async Task<Product> GetProduct(Guid id)
        {
            return await _repo.SelectById<Product>(id);
        }

        [HttpPost("[Action]")]
        public async Task CreateProduct(Product product)
        {
            await _repo.CreateAsync<Product>(product);
        }
        [HttpDelete("[Action]/{id}")]
        public async Task DeleteProduct(Product product)
        {
            await _repo.DeleteAsync<Product>(product);
        }
    }
}
