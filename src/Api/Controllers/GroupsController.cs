using Application.Contexts.Groups.Commands.CreateGroup;
using Application.Contexts.Groups.Commands.RemoveGroup;
using Application.Contexts.Groups.Dtos;
using Application.Contexts.Groups.Queries.GetAllGroups;
using Application.Contexts.Groups.Queries.GetGroupById;
using Application.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class GroupsController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<ResponseDto<Guid>>> CreateGroup([FromBody] CreateGroupCommand createGroupCommand)
    {
        var result = await mediator.Send(createGroupCommand);

        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult<ResponseDto<IEnumerable<GroupDto>>>> GetGroups()
    {
        var result = await mediator.Send(new GetAllGroupsQuery());

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GroupDto?>> GetGroup(Guid id)
    {
        var result = await mediator.Send(new GetGroupByIdQuery(id));

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ResponseDto>> DeleteGroup(Guid id)
    {
        var result = await mediator.Send(new RemoveGroupCommand(id));

        return Ok(result);
    }
}