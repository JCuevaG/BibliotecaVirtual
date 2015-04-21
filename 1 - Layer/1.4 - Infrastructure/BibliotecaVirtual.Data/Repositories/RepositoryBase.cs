using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaVirtual.Domain.Entities;
using System.Data.Entity;
using BibliotecaVirtual.Domain.Interfaces.Repositories;

namespace BibliotecaVirtual.Data.Repositories
{
    public class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TEntity : EntityBase
        where TContext : DbContext
    {
        protected TContext Context;

        public RepositoryBase(TContext context)
        {
            Context = context;
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> Get()
        {
            return Context.Set<TEntity>().AsQueryable();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList().AsEnumerable();
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }
    }
}
