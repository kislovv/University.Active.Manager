namespace University.Active.Manager.Storage;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

public static class Entry
{
    /// <summary>
    /// Добавления зависимостей для работы с БД
    /// </summary>
    /// <param name="serviceCollection">serviceCollection</param>
    /// <param name="optionsAction">optionsAction</param>
    /// <returns>IServiceCollection</returns>
    public static IServiceCollection AddDatabase(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddDbContext<AppDbContext>(optionsAction => 
        {
            optionsAction.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });
    }
}