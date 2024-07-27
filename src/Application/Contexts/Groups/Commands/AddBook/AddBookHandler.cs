using Application.Contexts.Groups.Repositories;
using Application.Dtos;
using Domain.Entities;
using MediatR;

namespace Application.Contexts.Groups.Commands.AddBook;

public class AddBookHandler(IBooksRepository booksRepository, IGroupsRepository groupsRepository)
    : IRequestHandler<AddBookCommand, ResponseDto<Guid>>
{
    public async Task<ResponseDto<Guid>> Handle(AddBookCommand request, CancellationToken cancellationToken)
    {
        var group = await groupsRepository.GetById(request.GroupId, cancellationToken);

        if (group == null)
            return new(false, Guid.Empty, $"Group by id {request.GroupId} not found");

        var entity = new Book(group, request.Title, request.Author, request.Pages, request.SourceUrl);

        entity = await booksRepository.Add(entity, cancellationToken);

        return new(true, entity.GuidId);
    }
}