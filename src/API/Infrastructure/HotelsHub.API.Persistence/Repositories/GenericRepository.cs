using HotelsHub.API.Application.Abstractions.Repositories;
using HotelsHub.API.Domain.Entities.Common;
using HotelsHub.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HotelsHub.API.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        protected readonly HotelsHubDBContext Context;

        public GenericRepository(HotelsHubDBContext context)
        {
            Context = context;
        }

        public ValueTask<T> GetByIdAsync(int id)
        {
            return Context.Set<T>().FindAsync(id);
        }
        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().FirstOrDefaultAsync(predicate);
        }
        public async Task AddAsync(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
            await Context.SaveChangesAsync();
        }
        public Task UpdateAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return Context.SaveChangesAsync();
        }
        public Task RemoveAsync(T entity)
        {
            Context.Set<T>().Remove(entity);
            return Context.SaveChangesAsync();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Context.Set<T>().ToListAsync();
        }
        public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await Context.Set<T>().Where(predicate).ToListAsync();
        }
        public Task<int> CountAllAsync() => Context.Set<T>().CountAsync();
        public Task<int> CountWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().CountAsync(predicate);
        }

    }
}
