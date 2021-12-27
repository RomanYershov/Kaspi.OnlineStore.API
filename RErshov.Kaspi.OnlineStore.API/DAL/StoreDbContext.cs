using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using RErshov.Kaspi.OnlineStore.API.Models;

namespace RErshov.Kaspi.OnlineStore.API.DAL
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products  { get; set; }
        public DbSet<OrderModel> Orders  { get; set; }
    }
}
