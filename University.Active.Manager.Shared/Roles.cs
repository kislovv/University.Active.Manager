#if CONTRACT_ASSEMBLY
namespace University.Active.Manager.Contracts.University;
#else
namespace University.Active.Manager.Entity;
#endif
/// <summary>
/// Роли в рамках приложения
/// </summary>
public enum Roles
{
    /// <summary>
    ///  Студент, может участвовать в  мероприятиях и распределять баллы по доступным предметам
    /// </summary>
    Student,

    /// <summary>
    /// Менеджер, может создавать, редактировать, удалять роли мероприятий, аксептовать регистрацию студентов на мероприятии
    /// </summary>
    Manager,

    /// <summary>
    /// Админ, управляет ролями пользователей (может назначить менеджера), создает мероприятия
    /// </summary>
    Admin
}
