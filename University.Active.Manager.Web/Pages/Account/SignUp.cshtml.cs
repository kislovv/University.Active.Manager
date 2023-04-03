using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Contracts.User;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Web.Pages.Account;

public class SignUp : PageModel
{
    private readonly IInstituteRepository _instituteRepository;
    private readonly IProfileService _profileService;
    private readonly IMapper _mapper;
    
    public SelectList Institutes { get; set; }

    [BindProperty]
    public UserRegistrationModel UserModel { get; set; }

    public SignUp(IInstituteRepository instituteRepository, IProfileService profileService, IMapper mapper)
    {
        _instituteRepository = instituteRepository;
        _profileService = profileService;
        _mapper = mapper;
    }
    public async Task OnGetAsync()
    {
        Institutes =  new SelectList(await _instituteRepository.GetAllInstitutes(),"Id", "Name");
    }

    public async Task OnPostAsync()
    {
        var user = _mapper.Map<User>(UserModel);
        user.Institute = Institutes.SelectedValue as Institute;
        
        await _profileService.SaveProfile(user);
        
        Redirect("Login");
    }
}