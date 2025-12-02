using Microsoft.AspNetCore.Mvc;
using LogisPe.Api.Shared;

namespace LogisPe.Api.Users;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    private readonly UsersService _svc;
    public UsersController(UsersService svc) { _svc = svc; }
    [HttpGet] public IActionResult List() => Ok(_svc.List());
    [HttpGet("{id:int}")] public IActionResult Get(int id) => _svc.Get(id) is { } v ? Ok(v) : NotFound(new { message = "users not found" });
    [HttpPost] public IActionResult Create([FromBody] User u) => Created(string.Empty, _svc.Create(u));
    [HttpPut("{id:int}")] public IActionResult Update(int id, [FromBody] User u) => _svc.Update(id, u) is { } v ? Ok(v) : NotFound(new { message = "users not found" });
    [HttpDelete("{id:int}")] public IActionResult Delete(int id) => _svc.Remove(id) is { } v ? Ok(v) : NotFound(new { message = "users not found" });
}