using app_teste.Models.Entities;

namespace app_teste.Models.Interfaces.Repository
{
    public interface IRepositoryUpdate<T> where T : BaseEntity
    {
        void Update(T obj);
    }
}
