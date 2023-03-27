using System.Threading.Tasks;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Abstraction;

public interface IProfileRepository
{
    Task<Profile> GetProfileByCredentials(string login, string password);
    Task<Profile> AddProfile(Profile profile);
}