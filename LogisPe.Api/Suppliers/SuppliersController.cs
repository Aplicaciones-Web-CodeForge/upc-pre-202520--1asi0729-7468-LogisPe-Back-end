using Microsoft.AspNetCore.Mvc;
using LogisPe.Api.Shared;

namespace LogisPe.Api.Suppliers;

[ApiController]
[Route("suppliers")]
public class SuppliersController : ControllerBase
{
    private readonly SuppliersService _svc;
    public SuppliersController(SuppliersService svc) { _svc = svc; }
    [HttpGet] public IActionResult List() => Ok(_svc.List());
    [HttpGet("{id:int}")] public IActionResult Get(int id) => _svc.Get(id) is { } v ? Ok(v) : NotFound(new { message = "suppliers not found" });
    [HttpPost] public IActionResult Create([FromBody] Supplier s) => Created(string.Empty, _svc.Create(s));
    [HttpPut("{id:int}")] public IActionResult Update(int id, [FromBody] Supplier s) => _svc.Update(id, s) is { } v ? Ok(v) : NotFound(new { message = "suppliers not found" });
    [HttpDelete("{id:int}")] public IActionResult Delete(int id) => _svc.Remove(id) is { } v ? Ok(v) : NotFound(new { message = "suppliers not found" });
}