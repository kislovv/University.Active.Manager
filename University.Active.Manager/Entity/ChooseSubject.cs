using System;

namespace University.Active.Manager.Entity;

/// <summary>
/// Выбранный предмет участника для начисления баллов
/// </summary>
public class ChooseSubject
{
    /// <summary>
    /// Уникальный идентификатор выбора
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Пользователь выбравший предмет
    /// </summary>
    public Guid ParticipantId { get; set; }
    public User Participant { get; set; }

    /// <summary>
    /// Предмет который выбрал участник
    /// </summary>
    public long SubjectId { get; set; }
    public Subject Subject { get; set; }

    /// <summary>
    /// Количество очков которое запрашивает студент
    /// </summary>
    public uint Score { get; set; }
}
