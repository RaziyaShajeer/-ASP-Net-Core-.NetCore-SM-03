using HospitalMgmt.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalMgmt.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            return services;
        }




    }
}
