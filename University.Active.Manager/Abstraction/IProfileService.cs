using System.Threading.Tasks;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Abstraction;

public interface IProfileService
{
    Task<Profile> SaveProfile(Profile profile);
    Task<Profile> Login(string login, string password);
}