using System.Collections.Generic;

namespace University.Active.Manager.Entity;

public class Subject
{
    public long Id { get; set; }
    public string Name { get; set; }
    public Specialty Specialty { get; set; }
    public IList<Institute> Insitutes { get; set; }
}