using StartUp.Quiz.Model.Entities;
using StartUp.Quiz.UnitOfWork.Collections;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Quiz.Service.Collections
{
   public interface IServiceBase<TEntity> where TEntity : class , IEntity
    {
        Task<IPagedList<TEntity>> GetAllAsync();        
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        TEntity Get(Guid id);
        TEntity Delete(Guid id);
    }
}
