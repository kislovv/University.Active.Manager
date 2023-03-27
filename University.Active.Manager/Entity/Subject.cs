using System.Collections.Generic;

namespace University.Active.Manager.Entity;

/// <summary>
/// Предмет в рамках института для начисления баллов
/// </summary>
public class Subject
{
    /// <summary>
    /// Идентификатор предмета
    /// </summary>
    public long Id { get; set; }
    /// <summary>
    /// Название предмета
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Направление образование предмета
    /// </summary>
    public Specialty Specialty { get; set; }
    
    /// <summary>
    /// Институты в которых есть этот предмет
    /// </summary>
    public List<Institute> Insitutes { get; set; }
}