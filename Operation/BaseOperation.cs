using System.Collections.Generic;
using System.Linq;
using AutoMapper.Internal;
using AutoMapper.QueryableExtensions;
using TCI.Domain;
using TCI.DomainService;
using TCI.Mapper;
using TCI.Model;

namespace TCI.Operation
{
    public abstract class BaseOperation<TEntity, TModel> : IBaseOperation<TEntity, TModel>
        where TEntity : BaseEntity
        where TModel : BaseModel
    {
        protected readonly IBaseService<TEntity> BaseService;

        protected BaseOperation(IBaseService<TEntity> baseService)
        {
            BaseService = baseService;
        }

        public List<TModel> GetAll()
        {
            return BaseService.GetAll().ProjectTo<TModel>().ToList();
        }

        public TModel Add(TModel model)
        {
            var entity = AutoMapper.Mapper.Map<TEntity>(model);
            BaseService.Add(entity);
            BaseService.Save();
            return AutoMapper.Mapper.Map<TModel>(entity);
        }

        public TModel Update(TModel model)
        {
            var entity = AutoMapper.Mapper.Map<TEntity>(model);
            BaseService.Update(entity);
            BaseService.Save();
            return AutoMapper.Mapper.Map<TModel>(entity);
        }

        public void Delete(TModel model)
        {
            var entity = AutoMapper.Mapper.Map<TEntity>(model);
            BaseService.Delete(entity);
            BaseService.Save();
        }
    }
}