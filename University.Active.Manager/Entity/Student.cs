namespace University.Active.Manager.Entity;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public byte Course { get; set; }
    public CourseType CourseType { get; set; }
    public Institute Institute { get; set; }
}