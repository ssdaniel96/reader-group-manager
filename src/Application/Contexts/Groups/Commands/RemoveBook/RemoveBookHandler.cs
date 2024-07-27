using Application.Contexts.Groups.Repositories;
using Application.Dtos;
using MediatR;

namespace Application.Contexts.Groups.Commands.RemoveBook;

public class RemoveBookHandler(IGroupsRepository groupsRepository, IBooksRepository booksRepository)
    : IRequestHandler<RemoveBookCommand, ResponseDto>
{
    public async Task<ResponseDto> Handle(RemoveBookCommand request, CancellationToken cancellationToken)
    {
        var group = await groupsRepository.GetById(request.GroupId, cancellationToken);

        if (group is null) return new(false, "Group not found");

        var book = await booksRepository.GetById(request.BookId, cancellationToken);

        if (book is null) return new(false, "Book not found");

        if (book.GroupId != group.Id) return new(false, "Book does not belong to this group");

        await booksRepository.Remove(book, cancellationToken);

        return new(true);
    }
}