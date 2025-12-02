using Microsoft.AspNetCore.Mvc;

namespace LogisPe.Api.IAM;

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{
    private readonly AuthService _svc;
    public AuthController(AuthService svc) { _svc = svc; }

    public record LoginDto(string email, string password);

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDto body)
    {
        var result = _svc.Login(body.email, body.password);
        if (result is null) return Unauthorized(new { message = "credenciales inválidas" });
        return Ok(new { user = result });
    }
}