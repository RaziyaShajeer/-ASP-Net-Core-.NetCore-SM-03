using Domain.Helper;
using Domain.Interface;
using Domain.Model;
using Domain.Repository;
using Domain.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extension
{
    public static class ApplicationServiceExtesionn
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
