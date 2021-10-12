using Domain.Entity.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IRepositoryBase<T> where T : EntityB
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
