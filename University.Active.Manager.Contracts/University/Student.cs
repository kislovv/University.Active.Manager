using University.Active.Manager.Contracts.User;

namespace University.Active.Manager.Contracts.University;

public class Student : Profile
{
    public byte Course { get; set; }
    public uint Score { get; set; }
    
    public CourseType CourseType { get; set; }

}