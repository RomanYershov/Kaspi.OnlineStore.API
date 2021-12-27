using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RErshov.Kaspi.OnlineStore.API.DAL;
using RErshov.Kaspi.OnlineStore.API.Models;

namespace RErshov.Kaspi.OnlineStore.API.BAL.Services
{
    public class ProductService : IStoreService<ProductModel>
    {
        private readonly StoreDbContext _dbContext;

        public ProductService(StoreDbContext dbContext) => _dbContext = dbContext;
        public IEnumerable<ProductModel> GetAll()
        {
            return _dbContext.Products;
        }

        public ProductModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
