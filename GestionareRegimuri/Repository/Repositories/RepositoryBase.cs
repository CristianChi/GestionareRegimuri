using GestionareRegimuri.Data;
using GestionareRegimuri.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GestionareRegimuri.Repository.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext DbContext { get; set; }

        public RepositoryBase(ApplicationDbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        public IQueryable<T> FindAll()
        {
            return DbContext.Set<T>().AsNoTracking();
        }

        public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return DbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            DbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            DbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

        public virtual void Reload(T entity)
        {
            DbContext.Entry(entity).Reload();
        }

        public virtual void LoadCollection(T entity, Expression<Func<T, IEnumerable<object>>> navigationProperty)
        {
            DbContext.Entry(entity).Collection<object>(navigationProperty).Load();
        }
    }
}
