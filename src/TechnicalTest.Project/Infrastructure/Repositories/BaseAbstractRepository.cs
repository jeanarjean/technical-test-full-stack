using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechnicalTest.Project.Domain;

namespace TechnicalTest.Project.Infrastructure.Repositories
{
    public abstract class BaseAbstractRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly TestDbContext _context;

        public BaseAbstractRepository(TestDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<T> GetAsync(string id)
        {
            return await _context.Set<T>().Where(x => x.Id == id).FirstAsync();
        }

        public async Task<T> CreateAsync(T entity)
        {
            _context.Add(entity);

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Update(entity);

            await _context.SaveChangesAsync();

            return entity;
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);

            _context.SaveChanges();
        }

        public abstract Task<T> GetIncludingRelationships(string id);

        public async Task<IEnumerable<T>> ListAsyncPaging(Expression<Func<T, bool>> filter, int currentPage, int pageSize)
        {
            return await _context.Set<T>().Where(filter).Skip((currentPage - 1) * pageSize).Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetCountAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().Where(filter).CountAsync();
        }
    }
}