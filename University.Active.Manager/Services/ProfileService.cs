using System.Threading.Tasks;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;
using University.Active.Manager.Utilities;

namespace University.Active.Manager.Services;

public class ProfileService : IProfileService
{

    private readonly IProfileRepository _profileRepository;
    private readonly HashHelper _hashHelper;
    public ProfileService(IProfileRepository profileRepository, HashHelper hashHelper)
    {
        _profileRepository = profileRepository;
        _hashHelper = hashHelper;
    }
    public async Task<User> SaveProfile(User profile)
    {
        profile.Password = _hashHelper.GetHashPassword(profile.Password);
        var result = await _profileRepository.AddProfile(profile);

        return result;
    }

    public Task<User> Login(string login, string password)
    {
        throw new System.NotImplementedException();
    }
}