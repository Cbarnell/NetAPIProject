using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class NameController : ControllerBase
{
    [HttpGet]
    public IActionResult GetName()
    {
        var data = new { Name = "Chase Barnell" };
        return Ok(data);
    }
}