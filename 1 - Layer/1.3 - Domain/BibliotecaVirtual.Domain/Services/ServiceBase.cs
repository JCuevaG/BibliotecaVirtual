using BibliotecaVirtual.Domain.Entities;
using BibliotecaVirtual.Domain.Interfaces.Repositories;
using BibliotecaVirtual.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> _repository)
        {
            this._repository = _repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<TEntity> Get()
        {
            return _repository.Get();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }
    }
}
