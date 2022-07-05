using app_teste.Models.Entities;
using System;
using System.Collections.Generic;

namespace app_teste.Models.Interfaces.Service
{
    public interface IServiceGet<T> where T : BaseEntity
    {
        T Get(int id);

        IList<T> Get();

        IEnumerable<T> Get(Func<T, bool> query);

        bool Exist(Func<T, bool> query);
    }
}
