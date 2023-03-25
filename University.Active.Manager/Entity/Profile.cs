using System;

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
    /// Отношение к студенту (может не быть студентом)
    /// </summary>
    public Student Student { get; set; }
    
    /// <summary>
    /// Почта учебная (логин)
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; }
    
    /// <summary>
    /// Авторизационная роль
    /// </summary>
    public string Role { get; set; }
}