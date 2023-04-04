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
    /// Институт в котором есть этот предмет
    /// </summary>
    public Institute Institute { get; set; }
    
    public long InstituteId { get; set; }

    /// <summary>
    /// Максимальный балл доступный для списания по этому предмету
    /// </summary>
    public uint MaxScore { get; set; }
}