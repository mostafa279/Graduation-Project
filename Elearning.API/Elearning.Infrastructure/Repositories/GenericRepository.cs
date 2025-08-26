using Elearning.Core.Interfaces;
using Elearning.Core.Specifications;
using Elearning.Infrastructure.Data;
using Elearning.Infrastructure.SpecificationsEvaluator;
using Microsoft.EntityFrameworkCore;

namespace Elearning.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
            => SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);

        public async Task<T?> GetByIdAsync(int id)
            => await _context.Set<T>().FindAsync(id)!;

        public async Task<IReadOnlyList<T>> ListAllAsync()
            => await _context.Set<T>().ToListAsync();

        public async Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec)
           => await ApplySpecification(spec).ToListAsync();

        public async Task<T?> GetEntityWithSpec(ISpecification<T> spec)
            => await ApplySpecification(spec).FirstOrDefaultAsync();

        public async Task<int> CountAsync(ISpecification<T> spec)
            => await ApplySpecification(spec).CountAsync();

        public void Add(T entity)
            => _context.Set<T>().Add(entity);

        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
            => _context.Set<T>().Remove(entity);
    }
}
