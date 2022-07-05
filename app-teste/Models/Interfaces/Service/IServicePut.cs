using app_teste.Models.Entities;
using FluentValidation;

namespace app_teste.Models.Interfaces.Service
{
    public interface IServicePut<T> where T : BaseEntity
    {
        T Put<V>(T obj) where V : AbstractValidator<T>;
    }
}
