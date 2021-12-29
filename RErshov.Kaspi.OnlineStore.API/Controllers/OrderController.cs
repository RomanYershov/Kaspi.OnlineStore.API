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
    public class OrderController : ControllerBase
    {
        private readonly IStoreService<OrderModel> _ordersService;

        public OrderController(IStoreService<OrderModel> service) => _ordersService = service;


        [HttpPost("[action]")]
        public void OrderInsert(OrderModel order)
        {
            _ordersService.Insert(order);
        }
        [HttpPost("[action]")]
        public void OrderUpdateStatus(OrderModel order)
        {
            _ordersService.Update(order);
        }
        [HttpGet("[action]")]
        public IEnumerable<OrderModel> GetAll()
        {
            return _ordersService.GetAll();
        }

    }
}