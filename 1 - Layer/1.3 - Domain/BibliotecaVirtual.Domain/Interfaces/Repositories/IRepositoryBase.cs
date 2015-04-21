using BibliotecaVirtual.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        void Add(TEntity entity);

        TEntity GetById(int id);

        IQueryable<TEntity> Get();
        
        IEnumerable<TEntity> GetAll();

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
