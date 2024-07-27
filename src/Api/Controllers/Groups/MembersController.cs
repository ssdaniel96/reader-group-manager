using Application.Contexts.Groups.Commands.AddMembers;
using Application.Contexts.Groups.Dtos;
using Application.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Groups;

[ApiController, Route("groups/{groupId:guid}/[controller]")]
public class MembersController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public ActionResult GetMembers(Guid groupId)
    {
        
        return Ok();
    }
    
    [HttpPost]
    public async Task<ActionResult<ResponseDto<List<MemberDto>>>> AddMembers(AddMembersCommand addMembersCommand)
    {
        var result = await mediator.Send(addMembersCommand);
        
        return Ok(result);
    }

    [HttpDelete]
    public ActionResult RemoveMembers(Guid groupId)
    {
        
        return Ok();
    }
    
}