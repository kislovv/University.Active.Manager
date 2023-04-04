using System.ComponentModel.DataAnnotations;
using University.Active.Manager.Contracts.University;

namespace University.Active.Manager.Contracts;

public class InstituteModel
{
    /// <summary>
    /// Идентификатор университета
    /// </summary>
    public long Id { get; set; }


    /// <summary>
    /// Название университета
    /// </summary>
    [Required(ErrorMessage = "У института должно быть имя!")]
    [MaxLength(InstituteMeta.NameMaxLength, ErrorMessage = "Привышена максимальная длина имени!")]
    public string Name { get; init; }

    /// <summary>
    /// Направление образования  
    /// </summary>
    public Specialty Specialty { get; init; }
}