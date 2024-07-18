using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController, Route("_[controller]")]
public class HealthCheckController : ControllerBase
{
    public ActionResult<string> GetStatus() => Ok("Healthy");
    
    public ActionResult<DateTime> GetDate()
    {
        return Ok(DateTime.Now);
    }
}