using Application.Contexts.Groups.Dtos;
using Application.Dtos;
using MediatR;

namespace Application.Contexts.Groups.Commands.UpdateBook;

public record UpdateBookCommand(
    Guid GroupId,
    Guid BookId,
    string Title,
    string Author,
    int Pages,
    string? SourceUrl)
    : IRequest<ResponseDto<BookDto>>;