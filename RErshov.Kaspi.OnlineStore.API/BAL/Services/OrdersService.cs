using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RErshov.Kaspi.OnlineStore.API.DAL;
using RErshov.Kaspi.OnlineStore.API.Models;

namespace RErshov.Kaspi.OnlineStore.API.BAL
{
    public class OrdersService : IStoreService<OrderModel>
    {
        private readonly StoreDbContext _dbContext;

        public OrdersService(StoreDbContext dbContext) => _dbContext = dbContext;

        public IEnumerable<OrderModel> GetAll()
        {
            var orders = _dbContext.Orders;
            return orders;
        }

        public OrderModel GetById(int id)
        {
            return _dbContext.Orders.Find(id);
        }

        public void Insert(OrderModel model)
        {
             model.CreatedAt = DateTime.Now;

            _dbContext.Add(model);
            _dbContext.SaveChanges();
        }

        public void Update(OrderModel model)
        {
            throw new NotImplementedException();
        }
    }
}
