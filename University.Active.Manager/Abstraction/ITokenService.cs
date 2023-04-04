using University.Active.Manager.Entity;

namespace University.Active.Manager.Abstraction;

public interface ITokenService
{
    string BuildToken(User user);
}