#if CONTRACT_ASSEMBLY
namespace University.Active.Manager.Contracts.University;
#else
namespace University.Active.Manager.Entity;
#endif

/// <summary>
/// Ограничения ролей мероприятий
/// </summary>
public class EventRoleMeta
{
    /// <summary>
    /// Максимальная длина названия роли
    /// </summary>
    public const int NameMaxLength = 1024;
}