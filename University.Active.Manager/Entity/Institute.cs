using System.Collections.Generic;

namespace University.Active.Manager.Entity;

public class Institute
{
    public string Name { get; init; }
    public Specialty Specialty { get; init; }
    public ICollection<Subject> Subjects { get; set; }
}