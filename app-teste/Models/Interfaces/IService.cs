using app_teste.Models.Entities;
using app_teste.Models.Interfaces.Service;

namespace app_teste.Models.Interfaces
{
    public interface IService<T> :
        IServicePost<T>,
        IServicePut<T>,
        IServiceGet<T>,
        IServiceDelete<T> where T : BaseEntity
    { }
}
