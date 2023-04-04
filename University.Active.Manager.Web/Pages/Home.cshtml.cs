using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using University.Active.Manager.Abstraction;

namespace University.Active.Manager.Web.Pages;
[Authorize(Roles = "Student, Manager, Admin")]
public class Home : PageModel
{
    private readonly IEventService _eventService;
    private readonly IMapper _mapper;

    public Home(IMapper mapper, IEventService eventService)
    {
        _eventService = eventService;
        _mapper = mapper;
    }
    public async Task<PageResult> OnGetAsync()
    { 
        return Page();
    }
}