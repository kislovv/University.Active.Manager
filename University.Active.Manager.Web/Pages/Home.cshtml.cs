using System;
using System.Collections.Generic;
using System.Linq;
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

    public Home(IEventService eventService)
    {
        _eventService = eventService;
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
                CourseType = CourseType.Bachelor,
                FirstName = "Кирилл",
                LastName = "Алексеевич",
                MiddleName = "Кислов"
            },
            ProfilePhotoPath = "photo.jpg"
        };

        var anyEvent = new Entity.Event()
        {
            Name = "Студвесна",
            EventId = Guid.NewGuid(),
            Place = "Уникс",
            Quota = 10,
            Score = 5,
            IsDone = false,
            Members = new List<Entity.Student>(),
            StartDateTime = new DateTime(2023, 03, 17, 18, 0, 0),
            EndDateTime = new DateTime(2023, 03, 17, 20, 0, 0)
        };
        
        
        await _eventService.RegisterNewEvent(anyEvent);
        
        Profile.Events.Add(_mapper.Map<Event>(anyEvent));
    }
}