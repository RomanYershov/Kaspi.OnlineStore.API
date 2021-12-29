using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RErshov.Kaspi.OnlineStore.API.Models
{
    public class ProductsOrders
    {
        public int ProductId{ get; set; }
        public ProductModel Product { get; set; }
        public int OrderId { get; set; }
        public OrderModel Order { get; set; }
    }
}
