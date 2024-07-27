using Application.Contexts.Groups.Dtos;
using Application.Dtos;
using MediatR;

namespace Application.Contexts.Groups.Commands.AddMembers;

public record AddMembersCommand(Guid GroupId, List<string> Names) : IRequest<ResponseDto<List<MemberDto>>>;