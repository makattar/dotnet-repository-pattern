using App.Persistence.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistence.Repository.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public DbSet<T> DbSet { get { return _dbSet; } }

        public async Task<T> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public async Task Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task Delete(int id)
        {
            T entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        //public async Task<IQueryable<T>> FindAllAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, bool>> orderBy, int? skip, int? take)
        //{
        //    IQueryable<T> query = _dbSet.AsQueryable();
        //    if(predicate.Parameters.Count() > 0)
        //    {
        //        query = query.Where(predicate);
        //    }

        //    if(orderBy.Parameters.Count() > 0)
        //    {
        //        query = query.OrderBy(orderBy);
        //    }


        //    if (skip.HasValue)
        //    {
        //        query = query.Skip(skip.Value);
        //    }

        //    if (take.HasValue)
        //    {
        //        query = query.Skip(take.Value);
        //    }

        //    return query;
        //}
    }
}
