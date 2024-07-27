using Application.Contexts.Groups.Dtos;
using Application.Contexts.Groups.Repositories;
using Application.Dtos;
using Domain.Entities;
using MapsterMapper;
using MediatR;

namespace Application.Contexts.Groups.Commands.AddMembers;

public class AddMembersHandler(IGroupsRepository groupsRepository, IMapper mapper)
    : IRequestHandler<AddMembersCommand, ResponseDto<List<MemberDto>>>
{
    public async Task<ResponseDto<List<MemberDto>>> Handle(AddMembersCommand request,
        CancellationToken cancellationToken)
    {
        var group = await groupsRepository.GetById(request.GroupId, cancellationToken);
        if (group == null) return new(false, null, "Group not found.");

        var members = request.Names.Select(x => new Member(x, group)).ToList();
        group.AddMembers(members);

        group = await groupsRepository.Update(group, cancellationToken);

        var membersDto = mapper.Map<List<MemberDto>>(group.Members);
        return new(true, membersDto);
    }
}