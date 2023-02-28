using System.Collections.Generic;
using System.Threading.Tasks;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Abstraction
{
    /// <summary>
    /// Сервис по управлению мероприятиями
    /// </summary>
    public interface IEventService
    {
        /// <summary>
        /// Получение всех активных (не завершенных) мероприятий
        /// </summary>
        /// <returns>Список активных мероприятий</returns>
        public Task<List<Event>> GetAllActiveEvents();
        
        /// <summary>
        /// Попытка добавить мероприятие в общий пул для возможности регистрации
        /// </summary>
        /// <param name="ev">Мероприятие которое пытаются добавить в список активных</param>
        /// <returns>успешность операции</returns>
        public Task<bool> RegisterNewEvent(Event ev);
    }
}