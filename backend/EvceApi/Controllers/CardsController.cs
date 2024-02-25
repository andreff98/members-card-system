using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace EvceApi.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CardsController : ControllerBase
{
    [Authorize]
    [HttpGet]
   public IActionResult GetCards()
    {

        // Access username claim from user's identity
        var usernameClaim = User.Claims.FirstOrDefault(c => c.Type == "user");
        var isAdminClaim = User.Claims.FirstOrDefault(c => c.Type == "isAdmin");
        var username = usernameClaim?.Value;
        var isAdmin = isAdminClaim?.Value;

        return new JsonResult(new { 
            Cards = new[] { "card1", "card2", "card3" }, 
            User = username,
            Admin = isAdmin
        });
    }
}