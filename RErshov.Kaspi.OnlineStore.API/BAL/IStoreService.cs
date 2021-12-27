using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RErshov.Kaspi.OnlineStore.API.Models;

namespace RErshov.Kaspi.OnlineStore.API.BAL
{
    public interface IStoreService<T> where T : ApiModelBase
    {
        void Insert(T model);
        void Update(T model);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
