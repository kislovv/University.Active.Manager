#if CONTRACT_ASSEMBLY
namespace University.Active.Manager.Contracts.University;
#else
namespace University.Active.Manager.Entity;
#endif

/// <summary>
/// Ограничения для параметров события 
/// </summary>
public class EventMeta
{
    /// <summary>
    /// Максимальная длина названия встречи
    /// </summary>
    public const int NameMaxLength = 1024;
    
    /// <summary>
    /// Максимальная длина названия адреса встречи
    /// </summary>
    public const int PlaceMaxLength = 1024;
}