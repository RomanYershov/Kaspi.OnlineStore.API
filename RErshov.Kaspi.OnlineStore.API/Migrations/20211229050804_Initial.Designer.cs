﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RErshov.Kaspi.OnlineStore.API.DAL;

namespace RErshov.Kaspi.OnlineStore.API.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20211229050804_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RErshov.Kaspi.OnlineStore.API.Models.OrderModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("CardNumber")
                        .IsRequired();

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired();

                    b.Property<int>("State");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("RErshov.Kaspi.OnlineStore.API.Models.ProductModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Cost = 250m,
                            ImgUrl = "https://st.depositphotos.com/1203063/2785/i/600/depositphotos_27856497-stock-photo-headphones.jpg",
                            Name = "Наушники: DT770 PRO"
                        },
                        new
                        {
                            ID = 2,
                            Cost = 170m,
                            ImgUrl = "https://st.depositphotos.com/1203063/2785/i/600/depositphotos_27856497-stock-photo-headphones.jpg",
                            Name = "Наушники: DT1001 PRO"
                        },
                        new
                        {
                            ID = 3,
                            Cost = 300m,
                            ImgUrl = "https://static7.depositphotos.com/1032712/785/i/600/depositphotos_7859145-stock-photo-red-headphones-3d-icon-isolated.jpg",
                            Name = "Наушники: DT880 PRO"
                        },
                        new
                        {
                            ID = 4,
                            Cost = 550m,
                            ImgUrl = "https://static7.depositphotos.com/1032712/785/i/600/depositphotos_7859145-stock-photo-red-headphones-3d-icon-isolated.jpg",
                            Name = "Наушники: DT8809 PRO"
                        },
                        new
                        {
                            ID = 5,
                            Cost = 500m,
                            ImgUrl = "https://st.depositphotos.com/1203063/2785/i/600/depositphotos_27856497-stock-photo-headphones.jpg",
                            Name = "Наушники: Senhizer DT880 PRO"
                        });
                });

            modelBuilder.Entity("RErshov.Kaspi.OnlineStore.API.Models.ProductsOrders", b =>
                {
                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductsOrders");
                });

            modelBuilder.Entity("RErshov.Kaspi.OnlineStore.API.Models.ProductsOrders", b =>
                {
                    b.HasOne("RErshov.Kaspi.OnlineStore.API.Models.OrderModel", "Order")
                        .WithMany("ProductOrder")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RErshov.Kaspi.OnlineStore.API.Models.ProductModel", "Product")
                        .WithMany("ProductOrder")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
