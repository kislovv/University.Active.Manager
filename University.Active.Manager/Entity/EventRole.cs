using System.Collections.Generic;

namespace University.Active.Manager.Entity;

/// <summary>
/// Роли участников любого мероприятия
/// </summary>
public class EventRole
{
    public string Name { get; set; }
    public uint Score { get; set; }
    public List<Event> Events { get; set; }
}