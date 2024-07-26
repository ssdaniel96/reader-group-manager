using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Groups;

[ApiController, Route("groups/{groupId:guid}/[controller]")]
public class BooksController : ControllerBase
{
    [HttpGet]
    public ActionResult GetBooks(Guid groupId)
    {
        return Ok();
    }
    
    [HttpPost]
    public ActionResult AddBook(Guid groupId)
    {
        return Ok();
    }

    [HttpDelete]
    public ActionResult RemoveBook(Guid groupId)
    {
        return Ok();
    }

    [HttpPut]
    public ActionResult UpdateBook(Guid groupId)
    {
        return Ok();
    }
}