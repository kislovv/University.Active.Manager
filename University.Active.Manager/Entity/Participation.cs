using System;

namespace University.Active.Manager.Entity;

/// <summary>
/// Участие в мероприятии
/// </summary>
public class Participation
{
    /// <summary>
    /// Кто участвует
    /// </summary>
    public User User { get; set; }
    public Guid UserId { get; set; }
    
    /// <summary>
    /// На каком мероприятии участие
    /// </summary>
    public Event Event { get; set; }
    public Guid EventId { get; set; }
    
    /// <summary>
    /// В какой роли участвует
    /// </summary>
    public EventRole EventRole { get; set; }
    public long EventRoleId { get; set; }
    
    /// <summary>
    /// Доказано ли участие модератором
    /// </summary>
    public bool IsVerified { get; set; }
}