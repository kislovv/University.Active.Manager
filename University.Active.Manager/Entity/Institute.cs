using System.Collections.Generic;

namespace University.Active.Manager.Entity;

/// <summary>
/// Институт в университете
/// </summary>
public class Institute
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
    
    /// <summary>
    /// Список предметов доступных для начисления доп баллов
    /// </summary>
    public List<Subject> Subjects { get; set; }
    
    /// <summary>
    /// Список пользователей закрепленных за институтом
    /// </summary>
    public List<User> Users { get; set; }
}