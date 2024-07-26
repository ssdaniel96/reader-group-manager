using Application.Contexts.Groups.Dtos;
using Application.Dtos;
using MediatR;

namespace Application.Contexts.Groups.Queries.GetGroupById;

public record GetGroupByIdQuery(Guid Id) : IRequest<ResponseDto<GroupDto>>;