using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RErshov.Kaspi.OnlineStore.API.BAL;
using RErshov.Kaspi.OnlineStore.API.DAL;
using RErshov.Kaspi.OnlineStore.API.Models;

namespace RErshov.Kaspi.OnlineStore.API.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IStoreService<ProductModel> _productService;

        public ProductsController(IStoreService<ProductModel> service) => _productService = service;


        [HttpGet("[action]")]
        public IEnumerable<ProductModel> GetProducts()
        {
            return _productService.GetAll();
        }



    }
}