using System;
using System.Collections.Generic;

namespace University.Active.Manager.Entity;

/// <summary>
/// Мероприятие проводимое в рамках университета
/// </summary>
public class Event
{
    /// <summary>
    /// Уникальный идентификатор события
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Список участников
    /// </summary>
    public List<User> Participants { get; set; }

    /// <summary>
    /// Роли в рамках мероприятия
    /// </summary>
    public List<EventRole> EventRoles { get; set; }
    
    /// <summary>
    /// Признак завершенности
    /// </summary>
    public bool IsDone { get; set; }
    
    /// <summary>
    /// Время начало события
    /// </summary>
    public DateTime StartDateTime { get; set; }
    
    /// <summary>
    /// Время завершения события
    /// </summary>
    public DateTime EndDateTime { get; set; }
    
    /// <summary>
    /// Место события (адрес)
    /// </summary>
    public string Place { get; set; }
    
    /// <summary>
    /// Название события 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Идентификатор создателя мероприятия
    /// </summary>
    public Guid CreatorId { get; set; }
    
    /// <summary>
    /// Создатель мероприятия
    /// </summary>
    public User Creator { get; set; }
} 