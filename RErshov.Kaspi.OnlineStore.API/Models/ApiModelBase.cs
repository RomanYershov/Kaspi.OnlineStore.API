using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RErshov.Kaspi.OnlineStore.API.Models
{
    public class ApiModelBase
    {
        [Key]
        public int ID { get; set; }
    }
}
