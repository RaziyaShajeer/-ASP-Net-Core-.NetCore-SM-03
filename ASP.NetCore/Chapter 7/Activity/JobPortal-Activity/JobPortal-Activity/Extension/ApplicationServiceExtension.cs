using JobPortal_Activity.Helpers;
using JobPortal_Activity.Interface;
using JobPortal_Activity.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortal_Activity.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
          (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<JobAppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();


            return services;
        }
    }
}
