using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using University.Active.Manager.Abstraction;
using Profile = University.Active.Manager.Contracts.User.Profile;

namespace University.Active.Manager.Web.Pages.Account;

public class SignUp : PageModel
{
    private readonly IInstituteRepository _instituteRepository;
    private readonly IProfileService _profileService;
    private readonly IMapper _mapper;
    
    public SelectList Institutes { get; set; }

    [BindProperty]
    public Profile Profile { get; set; }
    
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
        Profile.Role = Profile.ProfileType.ToString();
        var result = await _profileService.SaveProfile(_mapper.Map<Entity.Profile>(Profile));
        
        Redirect("Login");
    }
}