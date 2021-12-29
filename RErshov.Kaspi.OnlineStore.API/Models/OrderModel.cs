using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RErshov.Kaspi.OnlineStore.API.Enums;

namespace RErshov.Kaspi.OnlineStore.API.Models
{
    public class OrderModel : ApiModelBase
    {
        public OrderStateEnum State { get; set; }
        [Required]
        public String Address  { get; set; }
        [Required]
        public String CardNumber { get; set; }
        public DateTime? CreatedAt { get; set; }
       
        public ICollection<ProductsOrders> ProductOrder { get; set; }

        public OrderModel() => ProductOrder = new List<ProductsOrders>();
    }
}
