using Application.Contexts.Groups.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace Repository.Repositories.Groups;

public class BooksRepository(ApplicationDbContext dbContext) : Repository<Book>(dbContext), IBooksRepository
{
    public async Task<IEnumerable<Book>> GetAll(Guid groupId, CancellationToken cancellationToken = default)
    {
        return await dbContext.Books
            .Where(p => p.Group.GuidId == groupId)
            .ToListAsync(cancellationToken);
    }
}