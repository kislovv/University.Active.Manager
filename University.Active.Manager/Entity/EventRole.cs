using System.Collections.Generic;
using System.Security.AccessControl;

namespace University.Active.Manager.Entity;

/// <summary>
/// Роли участников любого мероприятия
/// </summary>
public class EventRole
{
    /// <summary>
    /// Уникальный идентификатор роли
    /// </summary>
    public long Id { get; set; }
    
    /// <summary>
    /// Название роли
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Количество полученных баллов за участие
    /// </summary>
    public uint Score { get; set; }
    
    /// <summary>
    /// Максимальное количество участников в рамках роли
    /// </summary>
    public uint Quota { get; set; }
    
    /// <summary>
    /// События в которых используется данная роль
    /// </summary>
    public List<Event> Events { get; set; }

    public List<Participation> Participants { get; set; } 
}