using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TechnicalTest.Project.Infrastructure.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> filter);

        Task<T> GetAsync(string id);

        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync(T entity);

        void Delete(T entity);

        Task<T> GetIncludingRelationships(string id);

        Task<IEnumerable<T>> ListAsyncPaging(Expression<Func<T, bool>> filter, int currentPage, int pageSize);

        Task<int> GetCountAsync(Expression<Func<T, bool>> filter);
    }
}