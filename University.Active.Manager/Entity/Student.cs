using System;
using System.Collections.Generic;

namespace University.Active.Manager.Entity;

/// <summary>
/// Модель студента
/// </summary>
public class Student : Profile
{
    /// <summary>
    /// Курс
    /// </summary>
    public byte Course { get; set; }
    
    /// <summary>
    /// Форма обучения
    /// </summary>
    public CourseType CourseType { get; set; }

    
}