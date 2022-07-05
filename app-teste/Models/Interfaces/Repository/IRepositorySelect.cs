using app_teste.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace app_teste.Models.Interfaces.Repository
{
    public interface IRepositorySelect<T> where T : BaseEntity
    {
        T Select(int id);

        Task<T> SelectAsync(int id);

        T SelectManyToMany(object id, object id2);

        IList<T> SelectAll();

        Task<IList<T>> SelectAllAsync();

        List<T> SelectBy(Func<T, bool> query);

        Task<IList<T>> SelectByAsync(Func<T, bool> query);

        bool Exist(Func<T, bool> query);
    }
}
