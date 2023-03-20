#if CONTRACT_ASSEMBLY
namespace University.Active.Manager.Contracts.University;
#else
namespace University.Active.Manager.Entity;
#endif

/// <summary>
/// Тип обучения 
/// </summary>
public enum CourseType
{
    /// <summary>
    /// Бакалавр
    /// </summary>
    Bachelor,
    
    /// <summary>
    /// Магистратура
    /// </summary>
    Master,
    
    /// <summary>
    /// Асперантура
    /// </summary>
    Graduate
}