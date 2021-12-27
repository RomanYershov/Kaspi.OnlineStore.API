using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RErshov.Kaspi.OnlineStore.API.Enums;

namespace RErshov.Kaspi.OnlineStore.API.Models
{
    public class OrderModel : ApiModelBase
    {
        public OrderStateEnum State { get; set; }
        public String Address  { get; set; }
        public String CardNumber { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
