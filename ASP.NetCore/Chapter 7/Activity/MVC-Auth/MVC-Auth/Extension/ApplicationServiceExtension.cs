using Microsoft.EntityFrameworkCore;
using MVC_Auth.Helper;
using MVC_Auth.Interface;
using MVC_Auth.Models;
using MVC_Auth.Repository;
using MVC_Auth.Service;

namespace MVC_Auth.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
          (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();


            return services;
        }
    }
}
