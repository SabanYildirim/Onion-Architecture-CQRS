using ProductApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity 
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid Id);
        Task<T> AddAsync(T entity);
    }
}
