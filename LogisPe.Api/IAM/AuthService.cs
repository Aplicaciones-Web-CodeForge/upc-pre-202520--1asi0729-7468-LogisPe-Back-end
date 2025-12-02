using System.Linq;
using LogisPe.Api.Shared;

namespace LogisPe.Api.IAM;

public class AuthService
{
    public object? Login(string email, string password)
    {
        var u = InMemoryDb.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
        if (u is null) return null;
        return new { id = u.Id, name = u.Name, email = u.Email, role = u.Role };
    }
}