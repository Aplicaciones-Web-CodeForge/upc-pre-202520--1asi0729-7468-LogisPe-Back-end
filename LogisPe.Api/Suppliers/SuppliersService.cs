using System.Linq;
using LogisPe.Api.Shared;

namespace LogisPe.Api.Suppliers;

public class SuppliersService
{
    public IEnumerable<Supplier> List() => InMemoryDb.Suppliers;
    public Supplier? Get(int id) => InMemoryDb.Suppliers.FirstOrDefault(x => x.Id == id);
    public Supplier Create(Supplier s) { var id = InMemoryDb.Suppliers.Any() ? InMemoryDb.Suppliers.Max(x => x.Id) + 1 : 1; s.Id = id; InMemoryDb.Suppliers.Add(s); return s; }
    public Supplier? Update(int id, Supplier s) { var idx = InMemoryDb.Suppliers.FindIndex(x => x.Id == id); if (idx == -1) return null; s.Id = id; InMemoryDb.Suppliers[idx] = s; return s; }
    public Supplier? Remove(int id) { var idx = InMemoryDb.Suppliers.FindIndex(x => x.Id == id); if (idx == -1) return null; var rem = InMemoryDb.Suppliers[idx]; InMemoryDb.Suppliers.RemoveAt(idx); return rem; }
}