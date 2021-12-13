using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RCSolutions.Infra;

namespace RCSolutions.IoC
{
    public static class DependencyInjectionServiceEF
    {
        public static void AddSqlConnectionEntityFramework(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<RCSolutionsContext>(options =>
                options.UseSqlServer(connectionString));

        }
    }
}
