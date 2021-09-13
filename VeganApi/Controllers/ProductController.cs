using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganApi.Interfaces;
using VeganApi.Models;

namespace VeganApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository _repo;
        public ProductController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _repo.SelectAll<Product>();
        }

        [HttpGet]
        public async Task<Product> GetProductAsync(Guid id)
        {
            return await _repo.SelectById<Product>(id);
        }
    }
}
