using Application.Dtos;
using MediatR;

namespace Application.Contexts.Groups.Commands.RemoveGroup;

public record RemoveGroupCommand(Guid GroupId) : IRequest<ResponseDto>
{
    public Guid Id { get; set; }
}