using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Contracts.User;

namespace University.Active.Manager.Web.Pages.Account;

[AllowAnonymous]
public class Login : PageModel
{
    private readonly IProfileService _profileService;
    private readonly ITokenService _tokenService;
    [BindProperty]
    public UserLoginModel UserLoginModel { get; set; }

    public string Token { get; set; }

    public bool IsAuth { get; set; } = true;
    public Login(IProfileService profileService, ITokenService tokenService)
    {
        _profileService = profileService;
        _tokenService = tokenService;
    }
    public async Task OnPostAsync()
    {
        var user = await _profileService.Login(UserLoginModel.Login, UserLoginModel.Password);
        IsAuth = user != null;
        if (user != null)
        {
            Token = _tokenService.BuildToken(user);
            Redirect("../Home");
        }
        else
        {
            RedirectToPage(); 
        }
    }
}