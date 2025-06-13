using Microsoft.EntityFrameworkCore;
using MVCassessment.Models;

namespace MVCassessment.Extension
{
    public static class AddApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options=>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                });
            return services;
        }
    }
}
