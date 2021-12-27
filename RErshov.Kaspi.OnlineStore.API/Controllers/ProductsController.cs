using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RErshov.Kaspi.OnlineStore.API.DAL;
using RErshov.Kaspi.OnlineStore.API.Models;

namespace RErshov.Kaspi.OnlineStore.API.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private StoreDbContext _db;

        public ProductsController(StoreDbContext dbContext) => _db = dbContext;


        [HttpGet("[action]")]
        public IEnumerable<ProductModel> GetProducts()
        {
            var products = _db.Products;

            return products;
        }



    }
}