using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistence.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        DbSet<T> DbSet { get; }
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Add(T entity);
        Task Delete(T entity);
        Task Delete(int id);
        Task Update(T entity);
        Task SaveChangesAsync();
        //Task<IQueryable<T>> FindAllAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, bool>> orderBy, int? skip, int? take);
    }
}
