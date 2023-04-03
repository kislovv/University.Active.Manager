namespace University.Active.Manager.Contracts.User;

public class UserRegistrationModel
{

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

    /// <summary>
    /// Логин пользователя
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// Почта вузовская для подтверждения почты
    /// </summary>
    public string Email { get; set; }


    /// <summary>
    /// Пароль пользователя
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Повторение пароля
    /// </summary>
    public string ConfirmPassword { get; set; }

}
