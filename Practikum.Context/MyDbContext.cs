using Microsoft.EntityFrameworkCore;
using Practikum.Repositories.Entities;
using Practikum.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practikum.Context
{
    public class MyDbContext:DbContext,IContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Child> Children { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source = SQLSRV; Initial Catalog = PractikumDbProject; Integrated Security = True;Trusted_Connection=True");
        }
    }
}
