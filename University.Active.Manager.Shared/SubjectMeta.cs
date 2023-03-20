#if CONTRACT_ASSEMBLY
namespace University.Active.Manager.Contracts.University;
#else
namespace University.Active.Manager.Entity;
#endif

/// <summary>
/// Ограничение для параметров предмета
/// </summary>
public class SubjectMeta
{
    /// <summary>
    /// Максималная длина названия предмета
    /// </summary>
    public const int NameMaxLength = 256;
    
    /// <summary>
    /// Максимальная длина специальности
    /// </summary>
    public const int SpecialtyMaxLength = 100;
}