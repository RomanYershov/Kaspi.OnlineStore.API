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
        public StoreDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
            
        }

        public DbSet<ProductModel> Products  { get; set; }
        public DbSet<OrderModel> Orders  { get; set; }
        public DbSet<ProductsOrders> ProductsOrders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasKey(p => p.ID);
            modelBuilder.Entity<OrderModel>().HasKey(o => o.ID);


            modelBuilder.Entity<ProductsOrders>()
                .HasKey(x => new {x.OrderId, x.ProductId});

            modelBuilder.Entity<ProductsOrders>()
                .HasOne(x => x.Product)
                .WithMany(o => o.ProductOrder)
                .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<ProductsOrders>()
                .HasOne(x => x.Order)
                .WithMany(o => o.ProductOrder)
                .HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<ProductModel>()
                .HasData(new ProductModel[]
                {
                    new ProductModel
                    {
                        ID = 1,
                        Name = "Наушники: DT770 PRO",
                        Cost = 250,
                        ImgUrl = "https://st.depositphotos.com/1203063/2785/i/600/depositphotos_27856497-stock-photo-headphones.jpg"
                    },
                    new ProductModel
                    {
                        ID = 2,
                        Name = "Наушники: DT1001 PRO",
                        Cost = 170,
                        ImgUrl = "https://st.depositphotos.com/1203063/2785/i/600/depositphotos_27856497-stock-photo-headphones.jpg"
                    },
                    new ProductModel
                    {
                        ID = 3,
                        Name = "Наушники: DT880 PRO",
                        Cost = 300,
                        ImgUrl = "https://static7.depositphotos.com/1032712/785/i/600/depositphotos_7859145-stock-photo-red-headphones-3d-icon-isolated.jpg"
                    },
                    new ProductModel
                    {
                        ID = 4,
                        Name = "Наушники: DT8809 PRO",
                        Cost = 550,
                        ImgUrl = "https://static7.depositphotos.com/1032712/785/i/600/depositphotos_7859145-stock-photo-red-headphones-3d-icon-isolated.jpg"
                    },
                    new ProductModel
                    {
                        ID = 5,
                        Name = "Наушники: Senhizer DT880 PRO",
                        Cost = 500,
                        ImgUrl = "https://st.depositphotos.com/1203063/2785/i/600/depositphotos_27856497-stock-photo-headphones.jpg"
                    }
                });


            //modelBuilder.Entity<OrderModel>()
            //    .HasOne(x => x.Products).WithMany();

            //modelBuilder.Entity<ProductModel>()
            //    .HasOne(x => x.Orders).WithMany();


        }
    }
}
