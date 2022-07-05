using app_teste.Models.Entities;

namespace app_teste.Models.Interfaces.Repository
{
    public interface IRepositoryRemove<T> where T : BaseEntity
    {
        void Remove(int id);
        void RemoveManyToMany(object id, object id2);
    }
}
