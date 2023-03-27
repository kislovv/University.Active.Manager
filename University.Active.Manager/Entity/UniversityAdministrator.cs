namespace University.Active.Manager.Entity;

/// <summary>
/// Администратор (управляющий мероприятиями)
/// </summary>
public class UniversityAdministrator : Profile
{
    /// <summary>
    /// Отдел администраци
    /// </summary>
    public string AdministrationDepartment { get; set; }
}