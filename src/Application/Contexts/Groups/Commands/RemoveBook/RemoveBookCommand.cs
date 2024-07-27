using Application.Dtos;
using MediatR;

namespace Application.Contexts.Groups.Commands.RemoveBook;

public record RemoveBookCommand(Guid GroupId, Guid BookId) : IRequest<ResponseDto>;