#if CONTRACT_ASSEMBLY
namespace University.Active.Manager.Contracts.University;
#else
namespace University.Active.Manager.Entity;
#endif

/// <summary>
/// Ограничение профиля
/// </summary>
public class ProfileMeta
{
    /// <summary>
    /// Максимальная длина почты
    /// </summary>
    public const int EmailMaxLength = 256;
    
    /// <summary>
    /// Максимальная длина пароля
    /// </summary>
    public const int PasswordMaxLength = 1024;
    
    /// <summary>
    /// Максимальная длина названия роли
    /// </summary>
    public const int RoleMaxLength = 100;
}