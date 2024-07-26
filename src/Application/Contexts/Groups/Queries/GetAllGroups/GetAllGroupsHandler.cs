using Application.Contexts.Groups.Dtos;
using Application.Contexts.Groups.Repositories;
using Application.Dtos;
using MapsterMapper;
using MediatR;

namespace Application.Contexts.Groups.Queries.GetAllGroups;

public class GetAllGroupsHandler(IGroupsRepository groupsRepository, IMapper mapper)
    : IRequestHandler<GetAllGroupsQuery, ResponseDto<IEnumerable<GroupDto>>>
{
    public async Task<ResponseDto<IEnumerable<GroupDto>>> Handle(GetAllGroupsQuery request,
        CancellationToken cancellationToken)
    {
        var entities = await groupsRepository.GetAll(cancellationToken);

        var result = mapper.Map<List<GroupDto>>(entities) ?? [];

        return new(result);
    }
}