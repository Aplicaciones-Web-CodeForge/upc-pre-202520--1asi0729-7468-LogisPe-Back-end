using System.Linq;
using LogisPe.Api.Shared;

namespace LogisPe.Api.Stores;

public class StoresService
{
    public IEnumerable<Store> List() => InMemoryDb.Stores;
    public Store? Get(int id) => InMemoryDb.Stores.FirstOrDefault(x => x.Id == id);
    public Store Create(Store s) { var id = InMemoryDb.Stores.Any() ? InMemoryDb.Stores.Max(x => x.Id) + 1 : 1; s.Id = id; InMemoryDb.Stores.Add(s); return s; }
    public Store? Update(int id, Store s) { var idx = InMemoryDb.Stores.FindIndex(x => x.Id == id); if (idx == -1) return null; s.Id = id; InMemoryDb.Stores[idx] = s; return s; }
    public Store? Remove(int id) { var idx = InMemoryDb.Stores.FindIndex(x => x.Id == id); if (idx == -1) return null; var rem = InMemoryDb.Stores[idx]; InMemoryDb.Stores.RemoveAt(idx); return rem; }
}