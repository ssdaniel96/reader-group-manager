using Application.Contexts.Groups.Dtos;
using Application.Contexts.Groups.Repositories;
using Application.Dtos;
using MapsterMapper;
using MediatR;

namespace Application.Contexts.Groups.Commands.UpdateBook;

public class UpdateBookHandler(IGroupsRepository groupsRepository, IBooksRepository booksRepository, IMapper mapper)
    : IRequestHandler<UpdateBookCommand, ResponseDto<BookDto>>
{
    public async Task<ResponseDto<BookDto>> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
    {
        var group = await groupsRepository.GetById(request.GroupId, cancellationToken);

        if (group is null) return new(false, null, "Group not found");

        var book = await booksRepository.GetById(request.BookId, cancellationToken);

        if (book is null) return new(false, null, "Book not found");
        if (book.GroupId != group.Id) return new(false, null, "Book does not belong to this group");

        book.UpdateData(request.Title, request.Author, request.Pages, request.SourceUrl);
        book = await booksRepository.Update(book, cancellationToken);

        return new(true, mapper.Map<BookDto>(book));
    }
}