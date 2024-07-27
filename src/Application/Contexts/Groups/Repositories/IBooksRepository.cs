using Application.Repositories;
using Domain.Entities;

namespace Application.Contexts.Groups.Repositories;

public interface IBooksRepository : IRepository<Book>
{
    Task<IEnumerable<Book>> GetAll(Guid groupId, CancellationToken cancellationToken = default);
}