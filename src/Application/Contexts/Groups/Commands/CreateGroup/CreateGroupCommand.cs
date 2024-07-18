using Application.Dtos;
using MediatR;

namespace Application.Contexts.Groups.Commands.CreateGroup;

public record CreateGroupCommand : IRequest<ResponseDto<Guid>>
{
    public string Name { get; set; } = string.Empty;
}