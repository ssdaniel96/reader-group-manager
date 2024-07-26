using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Groups;

[ApiController, Route("groups/{groupId:guid}/[controller]")]
public class MembersController : ControllerBase
{
    [HttpGet]
    public ActionResult GetMembers(Guid groupId)
    {
        
        return Ok();
    }
    
    [HttpPost]
    public ActionResult AddMembers(Guid groupId)
    {
        
        return Ok();
    }

    [HttpDelete]
    public ActionResult RemoveMembers(Guid groupId)
    {
        
        return Ok();
    }
    
}