#if CONTRACT_ASSEMBLY
namespace University.Active.Manager.Contracts.University;
#else
namespace University.Active.Manager.Entity;
#endif

/// <summary>
/// Ограничения для параметров Института
/// </summary>
public class InstituteMeta
{
    /// <summary>
    /// Максимальная длина имени института
    /// </summary>
    public const int NameMaxLength = 1024;
    
    /// <summary>
    /// максимальная длина специальности
    /// </summary>
    public const int SpecialtyMaxLength = 100;
    
    
}