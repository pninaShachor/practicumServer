
using Microsoft.Extensions.DependencyInjection;
using Practikum.Repositories.Interfaces;
using Practikum.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practikum.Repositories
{
    public static class Extensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IChildRepository, ChildRepository>();
            return services;
        }
    }
}
