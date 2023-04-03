using System.Threading.Tasks;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Abstraction;

public interface IProfileService
{
    Task<User> SaveProfile(User profile);
    Task<User> Login(string login, string password);
}