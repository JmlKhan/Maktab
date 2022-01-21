using Maktab.Core.IRepositories;
using Maktab.Model;
using Microsoft.EntityFrameworkCore;

namespace Maktab.Core.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AppDbContext _context;
        protected DbSet<T> dbSet;
        protected readonly ILogger _logger;

        public GenericRepository(AppDbContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<bool> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public async virtual Task<IEnumerable<T>> All()
        {
            return await dbSet.ToListAsync();
        }

        public virtual Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
