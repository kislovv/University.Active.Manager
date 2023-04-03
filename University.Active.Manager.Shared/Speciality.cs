#if CONTRACT_ASSEMBLY
namespace University.Active.Manager.Contracts;
#else
namespace University.Active.Manager.Entity;
#endif

/// <summary>
/// Специальность (направление) предмета/вуза
/// </summary>
public enum Specialty
{
  /// <summary>
  /// Технический
  /// </summary>
  Tech,
  
  /// <summary>
  /// Языки
  /// </summary>
  Language,
  
  /// <summary>
  /// История
  /// </summary>
  History,
  
  /// <summary>
  /// Математика
  /// </summary>
  Math,
  
  /// <summary>
  /// Экономический профиль
  /// </summary>
  Economics,
  
  /// <summary>
  /// Педагогика
  /// </summary>
  Education
}
