using BibliotecaVirtual.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaVirtual.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : EntityBase
    {
        void Add(TEntity entity);

        TEntity GetById(int id);

        IQueryable<TEntity> Get();

        IEnumerable<TEntity> GetAll();

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
