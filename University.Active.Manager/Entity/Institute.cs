using System.Collections.Generic;

namespace University.Active.Manager.Entity;

public class Institute
{
    public long Id { get; set; }
    public string Name { get; init; }
    public Specialty Specialty { get; init; }
    public List<Subject> Subjects { get; set; }
    public List<Student> Students { get; set; }
}