using Domain.Entities.Base;

namespace Application.Repositories;

public interface IRepository<TEntity> where TEntity : Entity
{
    Task<TEntity> Add(TEntity entity, CancellationToken cancellationToken = default);
    Task<TEntity> Update(TEntity entity, CancellationToken cancellationToken = default);
    Task Remove(TEntity entity, CancellationToken cancellationToken = default);
    Task<TEntity?> GetById(int id, CancellationToken cancellationToken = default);
    Task<TEntity?> GetById(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> GetAll(CancellationToken cancellationToken = default);
}