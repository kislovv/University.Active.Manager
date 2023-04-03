using System;
using System.Collections.Generic;

namespace University.Active.Manager.Entity;

/// <summary>
/// Модель пользователя
/// </summary>
public abstract class User
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Фамилия пользователя
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Отчество пользователя
    /// </summary>
    public string MiddleName { get; set; }
    
    public long InstituteId { get; set; }
    /// <summary>
    /// Институт пользователя
    /// </summary>
    public Institute Institute { get; set; }

    /// <summary>
    /// Логин пользователя
    /// </summary>
    public string Login { get; set; }
    
    /// <summary>
    /// Почта вузовская для подтверждения почты
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Ссылка на подтверждение почты
    /// </summary>
    public string EmailConfirmLink { get; set; }
    
    /// <summary>
    /// Признак подтверждения почты
    /// </summary>
    public bool EmailIsConfirm { get; set; }

    /// <summary>
    /// Пароль пользователя
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Авторизационная роль пользователя
    /// </summary>
    public string Role { get; set; }

    /// <summary>
    /// Список мероприятий в которых участвовал пользователь
    /// </summary>
    public List<Event> ParticipantEvents { get; set; }
    
    /// <summary>
    /// Список мероприятий в которые пользователь создал
    /// </summary>
    public List<Event> CreatedEvents { get; set; }

    /// <summary>
    /// Список предметов, выбранные для выставления баллов 
    /// </summary>
    public List<ChooseSubject> ChooseSubjects { get; set; }

    /// <summary>
    /// Роли которые принимал студент на мероприятиях
    /// </summary>
    public List<EventRole> EventRoles { get; set; }
}