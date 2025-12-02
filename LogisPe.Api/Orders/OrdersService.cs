using System.Linq;
using LogisPe.Api.Shared;

namespace LogisPe.Api.Orders;

public class OrdersService
{
    public IEnumerable<Order> List() => InMemoryDb.Orders;
    public Order? Get(int id) => InMemoryDb.Orders.FirstOrDefault(x => x.Id == id);
    public Order Create(Order o) { var id = InMemoryDb.Orders.Any() ? InMemoryDb.Orders.Max(x => x.Id) + 1 : 1; o.Id = id; InMemoryDb.Orders.Add(o); return o; }
    public Order? Update(int id, Order o) { var idx = InMemoryDb.Orders.FindIndex(x => x.Id == id); if (idx == -1) return null; o.Id = id; InMemoryDb.Orders[idx] = o; return o; }
    public Order? Remove(int id) { var idx = InMemoryDb.Orders.FindIndex(x => x.Id == id); if (idx == -1) return null; var rem = InMemoryDb.Orders[idx]; InMemoryDb.Orders.RemoveAt(idx); return rem; }
}