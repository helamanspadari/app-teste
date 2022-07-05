using app_teste.Models.Entities;

namespace app_teste.Models.Interfaces.Service
{
    public interface IServiceDelete<T> where T : BaseEntity
    {
        void Delete(int id);
        void DeleteManyToMany(object id, object id2);
    }
}
