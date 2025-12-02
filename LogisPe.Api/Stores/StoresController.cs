using Microsoft.AspNetCore.Mvc;
using LogisPe.Api.Shared;

namespace LogisPe.Api.Stores;

[ApiController]
[Route("stores")]
public class StoresController : ControllerBase
{
    private readonly StoresService _svc;
    public StoresController(StoresService svc) { _svc = svc; }
    [HttpGet] public IActionResult List() => Ok(_svc.List());
    [HttpGet("{id:int}")] public IActionResult Get(int id) => _svc.Get(id) is { } v ? Ok(v) : NotFound(new { message = "stores not found" });
    [HttpPost] public IActionResult Create([FromBody] Store s) => Created(string.Empty, _svc.Create(s));
    [HttpPut("{id:int}")] public IActionResult Update(int id, [FromBody] Store s) => _svc.Update(id, s) is { } v ? Ok(v) : NotFound(new { message = "stores not found" });
    [HttpDelete("{id:int}")] public IActionResult Delete(int id) => _svc.Remove(id) is { } v ? Ok(v) : NotFound(new { message = "stores not found" });
}