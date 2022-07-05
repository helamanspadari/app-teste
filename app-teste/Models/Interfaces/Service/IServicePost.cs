using app_teste.Models.Entities;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace app_teste.Models.Interfaces.Service
{
    public interface IServicePost<T> where T : BaseEntity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;
        Task<T> PostAsync<V>(T obj) where V : AbstractValidator<T>;
        Task PostListAsync(List<T> obj);
    }
}
