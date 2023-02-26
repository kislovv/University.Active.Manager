using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using University.Active.Manager.Contracts.Event;
using University.Active.Manager.Contracts.University;
using University.Active.Manager.Contracts.User;

namespace University.Active.Manager.Web.Pages;

public class Home : PageModel
{
    public Profile Profile { get; set; }
    
    public void OnGet()
    {
        Profile = new Profile
        {
            Events = new List<Event>()
            {
                new()
                {
                    Place = "Уникс",
                    Quota = 5,
                    Score = 2,
                    Name = "Студенческая весна",
                    IsDone = false,
                    StartDateTime = new DateTime(2023, 03, 17, 18, 0, 0),
                    EndDateTime = new DateTime(2023, 03, 17, 20, 0, 0)
                }
            },
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
    }
}