using Application.Dtos;
using MediatR;

namespace Application.Contexts.Groups.Commands.AddBook;

public record AddBookCommand(
    Guid GroupId,
    string Title,
    string Author,
    int Pages,
    string? SourceUrl)
    : IRequest<ResponseDto<Guid>>;