namespace University.Active.Manager.Storage.PgSql;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Microsoft.Extensions.Configuration;
using Abstraction;

public static class Entry
{
    /// <summary>
    /// Добавления зависимостей для работы с БД
    /// </summary>
    /// <param name="serviceCollection">Коллекция сервисов</param>
    /// <param name="configuration">Конфигурация приложения</param>
    /// <returns>IServiceCollection</returns>
    public static IServiceCollection AddDatabase(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddTransient<IEventRepository, EventRepository>();
        serviceCollection.AddTransient<ISubjectRepository, SubjectRepository>();
        serviceCollection.AddTransient<IUserRepository, UserRepository>();
        serviceCollection.AddTransient<IInstituteRepository, InstituteRepository>();
        return serviceCollection.AddDbContext<AppDbContext>(optionsAction => 
        {
            optionsAction.UseNpgsql(configuration["App:DbConnectionString"]);
            optionsAction.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsAction.UseSnakeCaseNamingConvention(CultureInfo.CurrentCulture);
        });
    }
}