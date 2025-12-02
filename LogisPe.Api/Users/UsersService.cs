using System.Linq;
using LogisPe.Api.Shared;

namespace LogisPe.Api.Users;

public class UsersService
{
    public IEnumerable<User> List() => InMemoryDb.Users;
    public User? Get(int id) => InMemoryDb.Users.FirstOrDefault(x => x.Id == id);
    public User Create(User u) { var id = InMemoryDb.Users.Any() ? InMemoryDb.Users.Max(x => x.Id) + 1 : 1; u.Id = id; InMemoryDb.Users.Add(u); return u; }
    public User? Update(int id, User u) { var idx = InMemoryDb.Users.FindIndex(x => x.Id == id); if (idx == -1) return null; var cur = InMemoryDb.Users[idx]; InMemoryDb.Users[idx] = new User{ Id=id, Name=u.Name, Email=u.Email, Password=u.Password, Role=u.Role }; return InMemoryDb.Users[idx]; }
    public User? Remove(int id) { var idx = InMemoryDb.Users.FindIndex(x => x.Id == id); if (idx == -1) return null; var rem = InMemoryDb.Users[idx]; InMemoryDb.Users.RemoveAt(idx); return rem; }
}