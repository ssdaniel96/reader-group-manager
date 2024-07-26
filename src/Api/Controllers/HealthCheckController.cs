using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController, Route("_[controller]")]
public class HealthCheckController : ControllerBase
{
    [HttpGet("status")]
    public ActionResult<string> GetStatus() => Ok("Healthy");
    
    [HttpGet("date")]
    public ActionResult<DateTime> GetDate()
    {
        return Ok(DateTime.Now);
    }
}