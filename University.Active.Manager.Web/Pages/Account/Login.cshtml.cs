using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using University.Active.Manager.Contracts.User;

namespace University.Active.Manager.Web.Pages.Account;

public class Login : PageModel
{
    [BindProperty]
    public Profile Profile { get; set; }
    public Login()
    {
        
    }
    public void OnGet()
    {
        
    }
}