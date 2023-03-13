using System;
using System.Collections.Generic;

namespace University.Active.Manager.Entity;

public class Student
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public byte Course { get; set; }
    public CourseType CourseType { get; set; }
    public long InstituteId { get; set; }
    public Institute Institute { get; set; }
    public IList<Event> Events { get; set; }
}