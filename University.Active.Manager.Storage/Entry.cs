namespace University.Active.Manager.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

public static class Entry
{
    private static readonly Action<DbContextOptionsBuilder> DefaultOptionsAction = (_) => { };

    /// <summary>
    /// Добавления зависимостей для работы с БД
    /// </summary>
    /// <param name="serviceCollection">serviceCollection</param>
    /// <param name="optionsAction">optionsAction</param>
    /// <returns>IServiceCollection</returns>
    public static IServiceCollection AddDatabase(this IServiceCollection serviceCollection,
        Action<DbContextOptionsBuilder>? optionsAction)
    {
        return serviceCollection.AddDbContext<AppDbContext>(optionsAction ?? DefaultOptionsAction);
    }
}