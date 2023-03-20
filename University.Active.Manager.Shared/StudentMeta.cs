#if CONTRACT_ASSEMBLY
namespace University.Active.Manager.Contracts.University;
#else
namespace University.Active.Manager.Entity;
#endif

/// <summary>
/// Ограничения для параметров студента
/// </summary>
public class StudentMeta
{
    /// <summary>
    /// Максимальная длина имени
    /// </summary>
    public const int FirstNameMaxLength = 256;
    
    /// <summary>
    /// Максимальная длина фамилии
    /// </summary>
    public const int LastNameMaxLength = 256;
    
    /// <summary>
    /// Максимальная длина отчества
    /// </summary>
    public const int MiddleNameMaxLength = 256;
}