using app_teste.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace app_teste.Models.Interfaces.Repository
{
    public interface IRepositoryInsert<T> where T : BaseEntity
    {
        void Insert(T obj);

        Task InsertListAsync(List<T> obj);

        Task InsertAsync(T obj);
    }
}
