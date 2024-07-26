using Application.Contexts.Groups.Repositories;
using Application.Dtos;
using MediatR;

namespace Application.Contexts.Groups.Commands.RemoveGroup;

public class RemoveGroupHandler(IGroupsRepository groupRepository) : IRequestHandler<RemoveGroupCommand, ResponseDto>
{
    public async Task<ResponseDto> Handle(RemoveGroupCommand request, CancellationToken cancellationToken)
    {
        var entity = await groupRepository.GetById(request.GroupId);

        if (entity == null)
        {
            return new(false, "Group not found");
        }
        
        await groupRepository.Remove(entity);

        return new(true);
    }
}