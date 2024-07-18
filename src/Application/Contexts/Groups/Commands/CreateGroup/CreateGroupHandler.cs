using Application.Contexts.Groups.Repositories;
using Application.Dtos;
using Domain.Entities;
using MediatR;

namespace Application.Contexts.Groups.Commands.CreateGroup;

public class CreateGroupHandler(IGroupsRepository groupsRepository)
    : IRequestHandler<CreateGroupCommand, ResponseDto<Guid>>
{
    public async Task<ResponseDto<Guid>> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
    {
        var entity = new Group(request.Name);

        entity = await groupsRepository.Add(entity);

        return new(entity.GuidId);
    }
}