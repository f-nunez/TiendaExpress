using Microsoft.AspNetCore.Mvc;

namespace Fnunez.TiendaExpress.Api.Controllers;

public class TestController : BaseApiController
{
    [HttpGet]
    public IActionResult TestString(string? anyString)
    {
        anyString ??= "Empty String!!!";

        return Ok(anyString);
    }
}