using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TCI.DataAccess;
using TCI.DataAccess.Interface;
using TCI.Domain;

namespace TCI.DomainService
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity>
        where TEntity : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<TEntity> _entities;

        protected BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _entities = unitOfWork.DbSet<TEntity>();
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null ? _entities : _entities.Where(predicate);
        }

        public TEntity GetFirst(Expression<Func<TEntity, bool>> predicate = null, List<string> includePaths = null)
        {
            var query = _entities.AsNoTracking();
            if (includePaths != null)
            {
                foreach (var include in includePaths)
                {
                    query = query.Include(include);
                }
            }
            return predicate == null ? query.First() : query.Where(predicate).First();
        }

        public void Add(TEntity entity)
        {
            _entities.Attach(entity);
        }

        public void Update(TEntity entity)
        {
            _entities.Attach(entity);
            _unitOfWork.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _unitOfWork.SaveChanges();
        }
    }
}