using System.Threading.Tasks;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Services;

public class ProfileService : IProfileService
{
    public Task<Profile> SaveProfile(Profile profile)
    {
        throw new System.NotImplementedException();
    }

    public Task<Profile> Login(string login, string password)
    {
        throw new System.NotImplementedException();
    }
}