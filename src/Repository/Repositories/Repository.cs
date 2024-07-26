using Application.Repositories;
using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace Repository.Repositories;

public abstract class Repository<TEntity>(ApplicationDbContext dbContext)
    : IRepository<TEntity> where TEntity : Entity
{
    public async Task<TEntity> Add(TEntity entity, CancellationToken cancellationToken = default)
    {
        dbContext.Set<TEntity>().Add(entity);
        await dbContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<TEntity> Update(TEntity entity, CancellationToken cancellationToken = default)
    {
        await dbContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task Remove(TEntity entity, CancellationToken cancellationToken = default)
    {
        dbContext.Set<TEntity>().Remove(entity);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<IEnumerable<TEntity>> GetAll(CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<TEntity>().ToListAsync(cancellationToken);
    }

    public async Task<TEntity?> GetById(int id, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<TEntity>().FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
    }


    public async Task<TEntity?> GetById(Guid id, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<TEntity>().FirstOrDefaultAsync(p => p.GuidId == id, cancellationToken);
    }
}