namespace University.Active.Manager.Contracts;

public class InstituteModel
{
    /// <summary>
    /// Идентификатор университета
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Название университета
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Направление образования  
    /// </summary>
    public Specialty Specialty { get; init; }
}
