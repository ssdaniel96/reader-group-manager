using Application.Repositories;
using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace Repository.Repositories;

public abstract class Repository<TEntity>(ApplicationDbContext dbContext) 
    : IRepository<TEntity> where TEntity : Entity
{
    public async Task<TEntity> Add(TEntity entity)
    {
        dbContext.Set<TEntity>().Add(entity);
        await dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> Update(TEntity entity)
    {
        await dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task Remove(TEntity entity)
    {
        dbContext.Set<TEntity>().Remove(entity);
        await dbContext.SaveChangesAsync();
    }

    public async Task<TEntity?> GetById(int id)
        => await dbContext.Set<TEntity>().FirstOrDefaultAsync(p => p.Id == id);


    public async Task<TEntity?> GetById(Guid id)
        => await dbContext.Set<TEntity>().FirstOrDefaultAsync(p => p.GuidId == id);
}