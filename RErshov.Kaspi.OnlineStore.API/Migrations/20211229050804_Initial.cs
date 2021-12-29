using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RErshov.Kaspi.OnlineStore.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    State = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    CardNumber = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductsOrders",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsOrders", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductsOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Cost", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { 1, 250m, "https://st.depositphotos.com/1203063/2785/i/600/depositphotos_27856497-stock-photo-headphones.jpg", "Наушники: DT770 PRO" },
                    { 2, 170m, "https://st.depositphotos.com/1203063/2785/i/600/depositphotos_27856497-stock-photo-headphones.jpg", "Наушники: DT1001 PRO" },
                    { 3, 300m, "https://static7.depositphotos.com/1032712/785/i/600/depositphotos_7859145-stock-photo-red-headphones-3d-icon-isolated.jpg", "Наушники: DT880 PRO" },
                    { 4, 550m, "https://static7.depositphotos.com/1032712/785/i/600/depositphotos_7859145-stock-photo-red-headphones-3d-icon-isolated.jpg", "Наушники: DT8809 PRO" },
                    { 5, 500m, "https://st.depositphotos.com/1203063/2785/i/600/depositphotos_27856497-stock-photo-headphones.jpg", "Наушники: Senhizer DT880 PRO" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOrders_ProductId",
                table: "ProductsOrders",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsOrders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
