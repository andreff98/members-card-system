using EvceApi.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EvceApi.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register()
    {
        return Ok();
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDto loginDto)
    {
        return Ok();
    }
}