using System;
using System.Collections.Generic;

namespace University.Active.Manager.Entity;

/// <summary>
/// Модель профиля пользователя
/// </summary>
public class Profile
{
    /// <summary>
    /// Идентификатор профиля
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; }
    
    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; set; }
    
    /// <summary>
    /// Отчество
    /// </summary>
    public string MiddleName { get; set; }
    
    public long InstituteId { get; set; }
    /// <summary>
    /// Институт профиля
    /// </summary>
    public Institute Institute { get; set; }

    /// <summary>
    /// Логин профиля
    /// </summary>
    public string Login { get; set; }
    
    /// <summary>
    /// Почта учебная (логин)
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Признак подтверждения пароля
    /// </summary>
    public bool EmailIsConfirm { get; set; }

    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; }
    
    /// <summary>
    /// Авторизационная роль
    /// </summary>
    public string Role { get; set; }
    
    /// <summary>
    /// Список мероприятий профиля
    /// </summary>
    public List<Event> Events { get; set; }
    
    /// <summary>
    /// Тип профиля (студент, управляющий и т.п.)
    /// </summary>
    public ProfileType ProfileType { get; set; }
}