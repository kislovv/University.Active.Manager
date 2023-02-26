namespace University.Active.Manager.Contracts.University;

public class Institute
{
    public string Name { get; init; }
    public Specialty Specialty { get; init; }
    public ICollection<Subject> Subjects { get; set; }
}