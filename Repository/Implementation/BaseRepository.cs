using Contracts.Interface;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly RepoDbContext _context;
        private readonly DbSet<T> _entity;

        public BaseRepository(RepoDbContext repoDbContext)
        {
            _context = repoDbContext;
            _entity = _context.Set<T>();
        }
        public void Create(T Entity)
        {
            _entity.Add(Entity);
        }

        public void Delete(T Entity)
        {
            _entity.Remove(Entity);
        }

        public IQueryable<T> GetAll(bool EnableTrackingChange)
        {
            return !EnableTrackingChange ? _entity.AsTracking().AsQueryable() : 
                _entity.AsQueryable();
        }

        public IQueryable<T> GetFilter(Expression<Func<T, bool>> expression, bool EnableTrackingChange)
        {
            return !EnableTrackingChange ? _entity.Where(expression).AsTracking().AsQueryable() :
                                           _entity.Where(expression).Where(expression).AsQueryable();
        }

        public void Update(T Entity)
        {
            _entity.Update(Entity);
        }
    }
}
