using Application.Contexts.Groups.Dtos;
using Application.Dtos;
using MediatR;

namespace Application.Contexts.Groups.Queries.GetAllGroups;

public record GetAllGroupsQuery : IRequest<ResponseDto<IEnumerable<GroupDto>>>
{
}