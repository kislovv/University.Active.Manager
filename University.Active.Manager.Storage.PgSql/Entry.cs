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
    /// <param name="serviceCollection">serviceCollection</param>
    /// <param name="optionsAction">optionsAction</param>
    /// <returns>IServiceCollection</returns>
    public static IServiceCollection AddDatabase(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddTransient<IEventRepository, EventRepository>();
        serviceCollection.AddTransient<ISubjectRepository, SubjectRepository>();
        return serviceCollection.AddDbContext<AppDbContext>(optionsAction => 
        {
            optionsAction.UseNpgsql(configuration["App:DbConnection"]);
            optionsAction.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsAction.UseSnakeCaseNamingConvention(CultureInfo.CurrentCulture);
            
        });
    }
}