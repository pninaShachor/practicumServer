
using Microsoft.Extensions.DependencyInjection;
using Practikum.Repositories;
using Practikum.Services.Interfaces;
using Practikum.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practikum.Services
{
    public static class Extentions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IClientService, ClientService>();
            services.AddAutoMapper(typeof(Mapping));
            return services;
        }
    }
}
