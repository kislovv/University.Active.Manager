using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Contracts.Event;
using University.Active.Manager.Contracts.University;
using Profile = University.Active.Manager.Contracts.User.Profile;

namespace University.Active.Manager.Web.Pages;

public class Home : PageModel
{
    private readonly IEventService _eventService;
    private readonly IMapper _mapper;
    public Profile Profile { get; set; }

    public Home(IMapper mapper, IEventService eventService)
    {
        _eventService = eventService;
        _mapper = mapper;
    }
    public async Task OnGetAsync()
    {
        Profile = new Profile
        {
            Events = new List<Event>(),
            Score = 10,
            Student = new Student()
            {
                Course = 2,
                Institute = new Institute(),
                CourseType = (Contracts.University.CourseType)CourseType.Bachelor,
                FirstName = "Кирилл",
                LastName = "Алексеевич",
                MiddleName = "Кислов"
            },
            ProfilePhotoPath = "photo.jpg"
        };

        var activeEvents = await _eventService.GetAllActiveEvents();
        var eventsFromFront = _mapper.Map<List<Event>>(activeEvents);
        
        eventsFromFront.ForEach(x => Profile.Events.Add(x));
    }
}