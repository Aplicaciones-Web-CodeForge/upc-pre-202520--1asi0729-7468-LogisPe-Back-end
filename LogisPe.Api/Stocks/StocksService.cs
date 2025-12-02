using System.Linq;
using LogisPe.Api.Shared;

namespace LogisPe.Api.Stocks;

public class StocksService
{
    public IEnumerable<Stock> List() => InMemoryDb.Stocks;
    public Stock? Get(int id) => InMemoryDb.Stocks.FirstOrDefault(x => x.Id == id);
    public Stock Create(Stock s) { var id = InMemoryDb.Stocks.Any() ? InMemoryDb.Stocks.Max(x => x.Id) + 1 : 1; s.Id = id; InMemoryDb.Stocks.Add(s); return s; }
    public Stock? Update(int id, Stock s) { var idx = InMemoryDb.Stocks.FindIndex(x => x.Id == id); if (idx == -1) return null; s.Id = id; InMemoryDb.Stocks[idx] = s; return s; }
    public Stock? Remove(int id) { var idx = InMemoryDb.Stocks.FindIndex(x => x.Id == id); if (idx == -1) return null; var rem = InMemoryDb.Stocks[idx]; InMemoryDb.Stocks.RemoveAt(idx); return rem; }
}