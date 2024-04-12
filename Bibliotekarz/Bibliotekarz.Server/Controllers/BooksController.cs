using Microsoft.AspNetCore.Mvc;

namespace Bibliotekarz.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    public BooksController()
    {
        
    }

    [HttpGet("All")]
    public async Task<IActionResult> GetAllBooks()
    {

        return Ok();
    }
}
