using Microsoft.AspNetCore.Mvc;
using LogisPe.Api.Shared;

namespace LogisPe.Api.Orders;

[ApiController]
[Route("orders")]
public class OrdersController : ControllerBase
{
    private readonly OrdersService _svc;
    public OrdersController(OrdersService svc) { _svc = svc; }
    [HttpGet] public IActionResult List() => Ok(_svc.List());
    [HttpGet("{id:int}")] public IActionResult Get(int id) => _svc.Get(id) is { } v ? Ok(v) : NotFound(new { message = "orders not found" });
    [HttpPost] public IActionResult Create([FromBody] Order o) => Created(string.Empty, _svc.Create(o));
    [HttpPut("{id:int}")] public IActionResult Update(int id, [FromBody] Order o) => _svc.Update(id, o) is { } v ? Ok(v) : NotFound(new { message = "orders not found" });
    [HttpDelete("{id:int}")] public IActionResult Delete(int id) => _svc.Remove(id) is { } v ? Ok(v) : NotFound(new { message = "orders not found" });
}