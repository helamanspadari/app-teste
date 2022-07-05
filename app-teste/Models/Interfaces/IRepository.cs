using app_teste.Models.Entities;
using app_teste.Models.Interfaces.Repository;

namespace app_teste.Models.Interfaces
{
    public interface IRepository<T> :
            IRepositoryInsert<T>,
            IRepositorySelect<T>,
            IRepositoryUpdate<T>,
            IRepositoryRemove<T> where T : BaseEntity
    { }
}
