using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RErshov.Kaspi.OnlineStore.API.Models;

namespace RErshov.Kaspi.OnlineStore.API.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("[action]")]
        public IEnumerable<ProductModel> GetProducts()
        {
            List<ProductModel> models = new List<ProductModel>();

            models.Add(new ProductModel
            {
                ID = 1,
                Name = "Наушники: DT770 PRO",
                Cost = 120,
                ImgUrl = "https://st.depositphotos.com/1203063/2785/i/600/depositphotos_27856497-stock-photo-headphones.jpg"
            });
            models.Add(new ProductModel
            {
                ID = 2,
                Name = "Наушники: DT880 PRO",
                Cost = 245,
                ImgUrl = "https://static7.depositphotos.com/1032712/785/i/600/depositphotos_7859145-stock-photo-red-headphones-3d-icon-isolated.jpg"
            });
            models.Add(new ProductModel
            {
                ID = 3,
                Name = "Наушники: DT1001 PRO",
                Cost = 430,
                ImgUrl = "https://static7.depositphotos.com/1032712/785/i/600/depositphotos_7859145-stock-photo-red-headphones-3d-icon-isolated.jpg"
            });
            models.Add(new ProductModel
            {
                ID = 4,
                Name = "Наушники: DT990 PRO",
                Cost = 220,
                ImgUrl = "https://static7.depositphotos.com/1032712/785/i/600/depositphotos_7859145-stock-photo-red-headphones-3d-icon-isolated.jpg"
            });
            models.Add(new ProductModel
            {
                ID = 5,
                Name = "Наушники: DT800 PRO",
                Cost = 245,
                ImgUrl = "https://static7.depositphotos.com/1032712/785/i/600/depositphotos_7859145-stock-photo-red-headphones-3d-icon-isolated.jpg"
            });
            models.Add(new ProductModel
            {
                ID = 6,
                Name = "Наушники: DT1301 PRO",
                Cost = 430,
                ImgUrl = "https://static7.depositphotos.com/1032712/785/i/600/depositphotos_7859145-stock-photo-red-headphones-3d-icon-isolated.jpg"
            });
            models.Add(new ProductModel
            {
                ID = 7,
                Name = "Наушники: DT990987 PRO",
                Cost = 220,
                ImgUrl = "https://static7.depositphotos.com/1032712/785/i/600/depositphotos_7859145-stock-photo-red-headphones-3d-icon-isolated.jpg"
            });

            return models;
        }



    }
}