using University.Active.Manager.Contracts.University;

namespace University.Active.Manager.Contracts.User;

public class Profile
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string ProfilePhotoPath { get; set; }
    public ProfileType ProfileType { get; set; }
    public Institute Institute { get; set; }
    public ICollection<Event.Event> Events { get; set; }
    public string Email { get; set; }
    
    public string Login { get; set; }

    public string Password { get; set; }

    public string Role { get; set; }
}