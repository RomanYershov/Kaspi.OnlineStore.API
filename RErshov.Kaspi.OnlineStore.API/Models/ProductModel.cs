using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RErshov.Kaspi.OnlineStore.API.Models
{
    public class ProductModel
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public Decimal Cost { get; set; }
        public String ImgUrl { get; set; }
    }
}
