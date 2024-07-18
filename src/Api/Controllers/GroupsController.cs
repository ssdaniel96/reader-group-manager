using Application.Contexts.Groups.Commands.CreateGroup;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController, Route("[controller]")]
public class GroupsController(IMediator mediator) : ControllerBase
{

    [HttpPost]
    public async Task<ActionResult> CreateGroup([FromBody] CreateGroupCommand createGroupCommand)
    {
        await mediator.Send(createGroupCommand);
        
        return Ok();
    }

    [HttpPost("{id}/members")]
    public ActionResult AddMembers(int id)
    {
        return Ok();
    }

    [HttpDelete("{id}/members")]
    public ActionResult RemoveMembers(int id)
    {
        return Ok();
    }

    [HttpPost("{id}/books")]
    public ActionResult AddBook(int id)
    {
        return Ok();
    }

    [HttpDelete("{id}/books")]
    public ActionResult RemoveBook(int id)
    {
        return Ok();
    }

    [HttpPut("{id}/books/{bookId}")]
    public ActionResult UpdateBook(int id, int bookId)
    {
        return Ok();
    }

}