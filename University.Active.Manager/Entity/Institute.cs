using System.Collections.Generic;

namespace University.Active.Manager.Entity;

public class Institute
{
    public long Id { get; set; }
    public string Name { get; init; }
    public Specialty Specialty { get; init; }
    public IList<Subject> Subjects { get; set; }
    public IList<Student> Students { get; set; }
}