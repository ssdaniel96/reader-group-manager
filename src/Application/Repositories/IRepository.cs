using Domain.Entities.Base;

namespace Application.Repositories;

public interface IRepository<TEntity> where TEntity : Entity
{
    Task<TEntity> Add(TEntity entity);
    Task<TEntity> Update(TEntity entity);
    Task Remove(TEntity entity);
    Task<TEntity?> GetById(int id);
    Task<TEntity?> GetById(Guid id);
}