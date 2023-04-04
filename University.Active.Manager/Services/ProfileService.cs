using System.Threading.Tasks;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;
using University.Active.Manager.Utilities;

namespace University.Active.Manager.Services;

public class ProfileService : IProfileService
{

    private readonly IUserRepository _userRepository;
    private readonly HashHelper _hashHelper;
    public ProfileService(IUserRepository userRepository, HashHelper hashHelper)
    {
        _userRepository = userRepository;
        _hashHelper = hashHelper;
    }
    public async Task<User> SaveProfile(User profile)
    {
        profile.Password = _hashHelper.GetHashPassword(profile.Password);
        var result = await _userRepository.AddUser(profile);

        return result;
    }

    public async Task<User> Login(string login, string password)
    {
        var user = await _userRepository.GetUserByLogin(login);
        
        //Если мы нашли пользователя но пароли не совпали - вернем пустоту, в дальнейшем сделаем Result класс для таких случаев
        if (user != null && user.Password != _hashHelper.GetHashPassword(password))
        {
            return null;
        }

        return user;
    }
}