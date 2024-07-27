using Application.Contexts.Groups.Dtos;
using Application.Dtos;
using MediatR;

namespace Application.Contexts.Groups.Queries.GetBooks;

public record GetBooksQuery(Guid GroupId) : IRequest<ResponseDto<List<BookDto>>>;