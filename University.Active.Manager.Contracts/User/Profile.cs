using University.Active.Manager.Contracts.University;

namespace University.Active.Manager.Contracts.User;

public class Profile
{
    public Student Student { get; set; }
    public string ProfilePhotoPath { get; set; }
    public ICollection<Event.Event> Events { get; set; }
    public uint Score { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }
}