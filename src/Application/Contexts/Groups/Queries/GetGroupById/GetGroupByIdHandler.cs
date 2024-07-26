using Application.Contexts.Groups.Dtos;
using Application.Contexts.Groups.Repositories;
using Application.Dtos;
using MapsterMapper;
using MediatR;

namespace Application.Contexts.Groups.Queries.GetGroupById;

public class GetGroupByIdHandler(IGroupsRepository groupsRepository, IMapper mapper)
    : IRequestHandler<GetGroupByIdQuery, ResponseDto<GroupDto>>
{
    public async Task<ResponseDto<GroupDto>> Handle(GetGroupByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await groupsRepository.GetById(request.Id, cancellationToken);

        if (entity == null)
            return new(true, null);

        var result = mapper.Map<GroupDto>(entity);

        return new(true, result);
    }
}